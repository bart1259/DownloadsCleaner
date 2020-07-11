using DownloadsCleanerConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DownloadsCleaner
{
    class Entry
    {
        static void Main(string[] args)
        {

            //Load config
            CleanerConfig config = CleanerConfig.ParseConfig(CleanerConfig.DEFAULT_CONFIG_PATH);

            Thread.Sleep(config.DelayedStart * 1000 * 60);

            //Create cleaner
            DirectoryCleaner cleaner = new DirectoryCleaner();
            cleaner.SetConfig(config);
            cleaner.Start();

            //Update cleaner if config changes
            ConfigWatcher watcher = null;
            watcher = new ConfigWatcher("CleanerSettings.xml", delegate {
                Console.WriteLine("Config Changed!");
                watcher.Stop();
                cleaner.Stop();
                CleanerConfig newConfig = CleanerConfig.ParseConfig(CleanerConfig.DEFAULT_CONFIG_PATH);
                cleaner.SetConfig(newConfig);
                cleaner.Start();
                watcher.Start();
            });
            watcher.Start();

            Console.ReadLine();
        }
    }
}
