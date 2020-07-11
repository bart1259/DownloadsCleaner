using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadsCleanerConfig
{
    public class SearchedDirectory
    {
        private string _directoryPath;
        private int _fileAgeLimit;

        /// <summary>
        /// The path of the directory that will be continuously searched
        /// for old files
        /// </summary>
        public string Path {
            get
            {
                return _directoryPath;
            }
            protected set
            {
                _directoryPath = value;
            }
        }

        /// <summary>
        /// The age limit in minutes of the minimum time since the file was deleted to
        /// be considered for deletion
        /// </summary>
        public int FileAgeLimit
        {
            get
            {
                return _fileAgeLimit;
            }
            set
            {
                _fileAgeLimit = value;
            }
        }

        /// <summary>
        /// Constructs a new directory that will be searched for old files
        /// </summary>
        /// <param name="path">The path of the directory</param>
        /// <param name="timeUntilDeletion">The minimum time a file must exist before it is considered for deletion</param>
        public SearchedDirectory(string path, int fileAgeLimit)
        {
            _directoryPath = path;
            _fileAgeLimit = fileAgeLimit;
        }

        public override bool Equals(object obj)
        {

            if (obj is SearchedDirectory)
            {
                return ((SearchedDirectory)obj).Path.Equals(Path, StringComparison.OrdinalIgnoreCase);
            }

            return base.Equals(obj);
        }
    }
}
