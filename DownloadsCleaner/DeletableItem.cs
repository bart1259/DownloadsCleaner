using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadsCleaner
{
    /// <summary>
    /// Represents the base class for a deletable file and directory
    /// </summary>
    public abstract class DeletableItem
    {
        public string Path { get; private set; }
        public int AgeToDelete { get; private set; }
        public DateTime LastAccessTime { get { return GetLastAccessTime(); } }
        public DateTime DeleteTime { get { return GetLastAccessTime().AddMinutes(AgeToDelete); } }

        protected DeletableItem(string path, int ageToDelete)
        {
            Path = path;
            AgeToDelete = ageToDelete;
        }

        /// <summary>
        /// Whether or not the file should be deleted
        /// </summary>
        /// <param name="within">used to check if a item would be deleted within so many minutes</param>
        /// <returns>whether or not the item should be deleted</returns>
        public bool ShouldBeDeleted(int within = 0)
        {
            return DeleteTime < DateTime.UtcNow.AddMinutes(within);
        }

        public abstract void Delete();

        /// <summary>
        /// Whether or not the item exists
        /// </summary>
        /// <returns>wheather or not the item exists</returns>
        public abstract bool Exists();

        /// <summary>
        /// Retrieves the last accessed time in UTC
        /// </summary>
        /// <returns>the last accessed time in UTC</returns>
        protected abstract DateTime GetLastAccessTime();

        public override string ToString()
        {
            return Path;
        }

        public override bool Equals(object obj)
        {
            if (obj is DeletableItem)
            {
                return ((DeletableItem)obj).Path.Equals(Path);
            }

            return base.Equals(obj);
        }

        /// <summary>
        /// Creates a new Deletable item
        /// </summary>
        /// <param name="path">the path to either the file or the directory</param>
        /// <returns>an instance of a deletable item</returns>
        public static DeletableItem Make(string path, int deletionAge)
        {
            if (File.Exists(path))
            {
                return new DeletableFile(path, deletionAge);
            } else if (Directory.Exists(path))
            {
                return new DeletableDirectory(path, deletionAge);
            }

            //Path is not valid
            return null;
        }
    }
}
