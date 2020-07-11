using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadsCleaner
{
    /// <summary>
    /// Class dedicated to determining if the config has changed
    /// </summary>
    class ConfigWatcher
    {
        public string ConfigPath { get; protected set; }
        public delegate void changeCB();

        private changeCB _callBack;
        private FileSystemWatcher _configWatcher;

        public ConfigWatcher(string configPath, changeCB callback)
        {
            ConfigPath = configPath;
            _callBack = callback;

            Console.WriteLine("---- " + Directory.GetCurrentDirectory());
            _configWatcher = new FileSystemWatcher(Directory.GetCurrentDirectory(), "CleanerSettings.xml");
            _configWatcher.NotifyFilter = NotifyFilters.LastWrite;
            _configWatcher.Changed += delegate {
                _callBack.Invoke();
            };
        }

        public void Start()
        {
            _configWatcher.EnableRaisingEvents = true;
        }

        public void Stop()
        {
            _configWatcher.EnableRaisingEvents = false;
        }
    }
}
