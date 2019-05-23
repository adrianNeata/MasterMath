using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Only support IList<int> Sort
    /// </summary>
    public static class BucketSorter
    {
        public static void BucketSort(IList<int> collection)
        {
            BucketSortAscending(collection);
        }

        /// <summary>
        /// Public API: Sorts ascending
        /// </summary>
        public static void BucketSortAscending(IList<int> collection)
        {
			  int maxValue = int.MinValue;
	        foreach (var value in collection)
	        {
		        if (value > maxValue) maxValue = value;
	        }

	        int minValue = int.MaxValue;

	        foreach (var value in collection)
	        {
		        if (value < minValue) minValue = value;
	        }
            
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            foreach (int i in collection) {
                bucket[i - minValue].Add(i);
            }

            int k = 0;
            foreach (List<int> i in bucket) {
                if (i.Count > 0)
                {
                    foreach (int j in i) 
                    {
                        collection[k] = j;
                        k++;
                    }
                }
            }
        }

        /// <summary>
        /// Public API: Sorts descending
        /// </summary>
        public static void BucketSortDescending(IList<int> collection)
        {
            int maxValue = collection[0];
            int minValue = collection[0];
            for (int i = 1; i < collection.Count; i++)
            {
                if (collection[i] > maxValue)
                    maxValue = collection[i];

                if (collection[i] < minValue)
                    minValue = collection[i];
            }
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            foreach (int i in collection)
            {
                bucket[i - minValue].Add(i);
            }

            int k = collection.Count-1;
            foreach (List<int> i in bucket)
            {
                if (i.Count > 0)
                {
                    foreach (int j in i)
                    {
                        collection[k] = j;
                        k--;
                    }
                }
            }
        }
    }
}
