using System.Collections.Generic;
using Algorithms.Common;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Also called Stupid Sort
    /// </summary>
    public static class GnomeSorter
    {
        public static void GnomeSort<T>(IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            GnomeSortAscending(collection,comparer);
        }

        /// <summary>
        /// Public API: Sorts ascending
        /// </summary>
        public static void GnomeSortAscending<T>(IList<T> collection, Comparer<T> comparer)
        {
            int pos = 1;
            while (pos < collection.Count)
            {
                if (comparer.Compare(collection[pos],collection[pos-1]) >= 0)
                {
                    pos++;
                }
                else
                {
                    collection.Swap(pos,pos-1);
                    if (pos > 1)
                    {
                        pos--;
                    }
                }
            }
        }

        /// <summary>
        /// Public API: Sorts descending
        /// </summary>
        public static void GnomeSortDescending<T>(IList<T> collection, Comparer<T> comparer)
        {
            int pos = 1;
            while (pos < collection.Count)
            {
                if (comparer.Compare(collection[pos], collection[pos - 1]) <= 0)
                {
                    pos++;
                }
                else
                {
                    collection.Swap(pos, pos - 1);
                    if (pos > 1)
                    {
                        pos--;
                    }
                }
            }
        }
    }
}
