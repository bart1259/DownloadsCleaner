
using DownloadsCleaner.deletionStrategies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using DownloadsCleanerConfig;

namespace DownloadsCleaner
{
    /// <summary>
    /// The main class that is responsible for cleaning directories.
    /// </summary>
    class DirectoryCleaner
    {
        
        public static DirectoryCleaner Instance { get; protected set; }


        //How many times per second the cleaner checks to see if 
        //any files need to be removed
        private const int CLEANER_RUN_INTERVAL = 30;

        private CleanerConfig _config;
        private List<DeletableItem> _itemsForDeletion;
        private DeletionStrategy _strategy;
        private FileWhiteList _whiteList;

        private bool _stopCleaning;
        private Thread _cleanerThread;
        private bool _askLater;

        /// <summary>
        /// Creates a blank directory cleaner
        /// </summary>
        public DirectoryCleaner()
        {
            //Establish singleton
            if (Instance == null)
            {
                Instance = this;
            }

            _itemsForDeletion = new List<DeletableItem>();
            _whiteList = new FileWhiteList();
        }

        public void RunCleaner()
        {

            //Run unless we need to stop
            while (_stopCleaning == false)
            {
                //Check if cleaner should stop and again ask later
                if (_askLater)
                {
                    Console.WriteLine("Asking later will take " + _config.BreakTime + " minute break!");
                    Thread.Sleep(1000 * 60 * _config.BreakTime);
                    _askLater = false;
                }

                Console.WriteLine("Does anything need to be cleaned?");
                //Search for new files
                SearchForFiles();

                //Run through every item to see if it should be deleted
                List<DeletableItem> deletionList = new List<DeletableItem>();
                bool deletingAFile = false;
                int combiningTime = 0;

                for (int index = 0; index < _itemsForDeletion.Count; index++)
                {
                    DeletableItem item = _itemsForDeletion[index];
                    Console.WriteLine("Considering " + item);
                    if (item.ShouldBeDeleted(combiningTime) && deletingAFile == false)
                    {
                        Console.WriteLine("Should be deleted!");

                        //Atleast one file must be deleted, so redo the search with a broader time search
                        //to avoid spamming the user
                        deletingAFile = true;
                        combiningTime = _config.CombineTime;
                        //Restart search
                        index = -1;
                        continue;
                    }

                    if (item.ShouldBeDeleted(combiningTime))
                    {
                        deletionList.Add(item);
                    }
                }

                //Clean those files
                Clean(deletionList);


                //Only run every so many seconds
                Console.WriteLine("Waiting on cleaner... " + _itemsForDeletion.Count + " possible files for cleaning");
                Thread.Sleep(CLEANER_RUN_INTERVAL * 1000);
            }

            //Reset lists and whitelist
            _itemsForDeletion = new List<DeletableItem>();
            _whiteList = new FileWhiteList();
        }

        public void Clean(List<DeletableItem> files)
        {
            Console.WriteLine("Deleting " + files.Count + " files");
            if (files.Count == 0)
            {
                return;
            }

            for (int i = 0; i < files.Count; i++)
            {
                Console.WriteLine("Deleting: " + files[i]);
            }
            _strategy.DeleteFile(files);
        }

        public void SetWhiteListedFiles(List<DeletableItem> whiteListedFiles)
        {
            //Remove all deleted files from the files for deletion
            for (int i = 0; i < whiteListedFiles.Count; i++)
            {
                _itemsForDeletion.Remove(whiteListedFiles[i]);
                _whiteList.AddToWhiteList(whiteListedFiles[i]);
            }
        }

        public void SetDeletedFiles(List<DeletableItem> deletedFiles)
        {
            //Remove all deleted files from the files for deletion
            for (int i = 0; i < deletedFiles.Count; i++)
            {
                _itemsForDeletion.Remove(deletedFiles[i]);
            }
        }

        public void TakeBreak()
        {
            _askLater = true;
        }

        public void Start()
        {
            Console.WriteLine("Starting Cleaner!");
            _stopCleaning = false;
            _cleanerThread = new Thread(RunCleaner);
            _cleanerThread.Start();
        }

        public void Stop()
        {
            Console.WriteLine("Stopping cleaner!");
            _stopCleaning = true;
            //Wait until the thread is killed
            while (_cleanerThread.IsAlive)
            {
                Thread.Sleep(100);
            }
            Console.WriteLine("Stopped!");
        }

        public void SetConfig(CleanerConfig config)
        {
            _config = config;

            Console.WriteLine("Loading deletion: " + _config.DeletionStrategy);
            _strategy = DeletionStrategy.GetStrategy(_config.DeletionStrategy);
            Console.WriteLine(_strategy.GetType());
            if (_strategy is NotifyDeletionStrategy)
            {
                //Set notify deletion strategy data
                ((NotifyDeletionStrategy)_strategy).SetSettings(_config.PromptValue, _config.DefaultKeep);
            }

            SearchForFiles();
        }


        /// <summary>
        /// Searches for all old files that are ready to be deleted
        /// </summary>
        /// <param name="delayedStart">If an item should be deleted now, what time should it be delayed to</param>
        public void SearchForFiles()
        {
            //Search through all directories
            for (int i = 0; i < _config.SearchedDirectories.Count; i++)
            {
                SearchedDirectory searchedDirectory = _config.SearchedDirectories[i];
                int deletionTime = _config.SearchedDirectories[i].FileAgeLimit;

                //Ensure directory exists
                if (Directory.Exists(searchedDirectory.Path) == false)
                {
                    continue;
                }

                //Find all files in directory
                DeletableItem[] files = Directory.GetFiles(searchedDirectory.Path, "*").Select(s => DeletableItem.Make(s, deletionTime)).ToArray();
                //Search for directories as well
                DeletableItem[] directories = Directory.GetDirectories(searchedDirectory.Path, "*", SearchOption.TopDirectoryOnly).Select(s => DeletableItem.Make(s, deletionTime)).ToArray();


                //Combine files and directories into one array
                DeletableItem[] itemsInDirectory = new DeletableItem[files.Length + directories.Length];
                files.CopyTo(itemsInDirectory, 0);
                directories.CopyTo(itemsInDirectory, files.Length);

                for (int j = 0; j < itemsInDirectory.Length; j++)
                {
                    DeletableItem item = itemsInDirectory[j];
                    //Ensure file is not whitelisted or already is in cleaner
                    if (_whiteList.IsInWhiteList(item) || _itemsForDeletion.Contains(item))
                    {
                        continue;
                    }

                    DateTime timeToDelete = item.DeleteTime;
                    Console.WriteLine(item.Path + " is " + (timeToDelete - DateTime.UtcNow).TotalMinutes + " minutes off, deleted: " + item.ShouldBeDeleted());

                    _itemsForDeletion.Add(item);
                }
            }
        }

    }
}
