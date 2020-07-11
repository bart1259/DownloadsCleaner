using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadsCleaner.deletionStrategies
{
    public abstract class DeletionStrategy
    {
        /// <summary>
        /// Deletes the file
        /// </summary>
        /// <param name="items">the items of the file to be deleted</param>
        public abstract void DeleteFile(List<DeletableItem> items);

        /// <summary>
        /// Returns the strategy from the name of the strategy
        /// </summary>
        /// <param name="name">name of the strategy</param>
        /// <returns>an instance of the strategy</returns>
        public static DeletionStrategy GetStrategy(string name)
        {
            if (name.Equals("Notify", StringComparison.OrdinalIgnoreCase))
            {
                return new NotifyDeletionStrategy();
            }
            return new BasicDeletionStrategy();
        }
    }
}
