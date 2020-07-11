using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DownloadsCleaner.utils;

namespace DownloadsCleaner
{
    public class DeletableDirectory : DeletableItem
    {
        public DeletableDirectory(string path, int deletionAge) : base(path, deletionAge) { }

        public override void Delete()
        {
            try
            {
                Directory.Delete(Path, true);
            }
            catch (Exception) { }
        }

        public override bool Exists()
        {
            return Directory.Exists(Path);
        }

        protected override DateTime GetLastAccessTime()
        {
            return Directory.GetLastAccessTimeUtc(Path);
        }

        public override string ToString()
        {
            string folderName = Path.Split('\\', '/').Last();
            return "/" + folderName;
        }

    }
}
