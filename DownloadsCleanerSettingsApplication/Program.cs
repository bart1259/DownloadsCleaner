using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadsCleanerSettingsApplication
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CleanerSettingsApplication currentApp = null;

            NotifyIcon appNotifyIcon = new NotifyIcon();
            appNotifyIcon.Visible = true;
            appNotifyIcon.Icon = new System.Drawing.Icon("AppIcon.ico");
            appNotifyIcon.Click += delegate
            {
                if (currentApp == null || currentApp.IsDisposed)
                {
                    currentApp = new CleanerSettingsApplication();
                    currentApp.Show();
                }
            };
            Application.Run();

            while (true)
            {
                Thread.Sleep(1000);
            }


        }
    }
}
