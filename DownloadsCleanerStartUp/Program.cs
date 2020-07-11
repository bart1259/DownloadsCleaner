using System.Diagnostics;

namespace DownloadsCleanerStartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the two other programs
            Process.Start("DownloadsCleaner.exe");
            Process.Start("DownloadsCleanerSettingsApplication.exe");
        }
    }
}
