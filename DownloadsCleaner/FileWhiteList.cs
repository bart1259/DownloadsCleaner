using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadsCleaner
{
    /// <summary>
    /// Class responsible for keeping track of all files that
    /// are not to be deleted by the software because they were
    /// previously denied
    /// </summary>
    class FileWhiteList
    {
        public static string WHITE_LIST_PATH = "whiteListedFiles.dat";

        /// <summary>
        /// Stores all the pathes to files that are whitelisted. The key is
        /// the file path and the value is also the path
        /// </summary>
        private SortedList<string, string> _whiteListedFiles;

        public FileWhiteList()
        {
            _whiteListedFiles = new SortedList<string, string>();

            //Ensure whitelist file exists
            if (File.Exists(WHITE_LIST_PATH) == false)
            {
                //File doesn't exist. Create it
                File.Create(WHITE_LIST_PATH).Close();
            }
            string[] files = File.ReadAllLines(WHITE_LIST_PATH);
            Console.WriteLine("Loading " + files.Length + " whitelisted files");

            //Clean file
            //The file is rewritten every time to ensure the files still exist
            File.WriteAllText(WHITE_LIST_PATH, string.Empty);

            for (int i = 0; i < files.Length; i++)
            {
                //If the item is succsfully added append it to the file
                //Make temp item
                DeletableItem item = DeletableItem.Make(files[i], 0);
                AddToWhiteList(item);
            }
        }

        public void AddToWhiteList(DeletableItem item)
        {
            if (item == null)
            {
                return;
            }

            //Ensure item actually exists
            if (item.Exists())
            {
                Console.WriteLine("Added " + item.Path + " to whitelist");
                _whiteListedFiles.Add(item.Path, item.Path);
                File.AppendAllText(WHITE_LIST_PATH, item.Path + "\r\n");
            }
        }

        public bool IsInWhiteList(DeletableItem item)
        {
            return _whiteListedFiles.ContainsKey(item.Path);
        }
    }
}
