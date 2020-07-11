using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadsCleaner.utils
{
    public static class FileSizeConvertor
    {
        public static string Convert(long numberOfBytes)
        {
            if (numberOfBytes < 1000)
            {
                return numberOfBytes + " B";
            } else if (numberOfBytes < 1_000_000)
            {
                return (numberOfBytes / 1000.0).ToString("0.0") + "KB";
            } else if (numberOfBytes < 1_000_000_000)
            {
                return (numberOfBytes / 1_000_000.0).ToString("0.0") + "MB";
            }
            else if (numberOfBytes < 1_000_000_000_000)
            {
                return (numberOfBytes / 1_000_000_000.0).ToString("0.0") + "GB";
            }
            else
            {
                return (numberOfBytes / 1_000_000_000_000.0).ToString("0.0") + "TB";
            }
        }

    }
}
