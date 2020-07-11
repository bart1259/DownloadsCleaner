using DownloadsCleaner.guis;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DownloadsCleaner.deletionStrategies
{
    class NotifyDeletionStrategy : DeletionStrategy
    {

        private int _decisionTime = 1;
        private bool _defaultKeep = true;

        public override void DeleteFile(List<DeletableItem> items)
        {
            Application.EnableVisualStyles();
            Application.Run(new NotificationForm(items, _decisionTime, _defaultKeep, DoneCallback));

        }

        private void DoneCallback(List<DeletableItem> deleteFiles, List<DeletableItem> notDeleteFiles, bool delayed)
        {
            if (delayed)
            {
                DirectoryCleaner.Instance.TakeBreak();
                return;
            }

            for (int i = 0; i < deleteFiles.Count; i++)
            {
                deleteFiles[i].Delete();
                Console.WriteLine("Deleted " + deleteFiles[i]);
            }
            DirectoryCleaner.Instance.SetDeletedFiles(deleteFiles);
            DirectoryCleaner.Instance.SetWhiteListedFiles(notDeleteFiles);
        }

        public void SetSettings(int decisionTime, bool defaultKeep)
        {
            _decisionTime = decisionTime;
            _defaultKeep = defaultKeep;
        }
    }
}
