using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DownloadsCleaner.utils;

namespace DownloadsCleaner
{
    public class DeletableFile : DeletableItem
    {
        public DeletableFile(string path, int deletionAge) : base(path, deletionAge) { }

        public override void Delete()
        {
            try
            {
                File.Delete(Path);
            }
            catch (Exception) { }
        }

        public override bool Exists()
        {
            return File.Exists(Path);
        }

        protected override DateTime GetLastAccessTime()
        {
            return File.GetLastAccessTimeUtc(Path);
        }

        public override string ToString()
        {
            string fileName = Path.Split('\\', '/').Last();
            string fileSize = "0 B";
            try
            {
                fileSize = FileSizeConvertor.Convert(new FileInfo(Path).Length);
            }
            catch (Exception) { }
            fileSize = fileSize.PadRight(8);
            return fileSize + " " + fileName;
        }
    }
}
