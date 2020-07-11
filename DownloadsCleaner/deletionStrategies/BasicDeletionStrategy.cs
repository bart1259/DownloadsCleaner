using System.Collections.Generic;
using System.IO;

namespace DownloadsCleaner.deletionStrategies
{
    class BasicDeletionStrategy : DeletionStrategy
    {
        public override void DeleteFile(List<DeletableItem> items)
        {
            foreach (DeletableItem item in items)
            {
                item.Delete();
            }

            DirectoryCleaner.Instance.SetDeletedFiles(items);
        }
    }
}
