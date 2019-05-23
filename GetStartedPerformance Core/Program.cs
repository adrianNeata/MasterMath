using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Algorithms.Sorting;

namespace GetStartedPerformance_Core
{
	class Program
	{
		static void Main(string[] args)
		{
<<<<<<< Updated upstream
			List<int> myList = null;
			List<int> listToSort = null;
			int[] myArray;
=======
			Stream fileStream = File.Create(@"C:\Users\Public\Logi\TextCore10.txt");

			using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileStream))
			{
				//BaseConverter(file);
				//PrimeEuler(file);
				//MaximumArraySum(file);
				//NumberOfDigitsUpToN(file);
				//ProductOfBigNumbers(file);
				//VietteSums(file);
				//BinaryCode(file);
				//GrayCode(file);
				//Permutation(file);
				//Combinations(file);
				//GeneratePartitions(file);
				//GenerateDistinctPartitions(file);
				//DecomposingNtoM(file);
				DecomposingNtoMDistinct(file);
				DecomposingNtoPartitions(file);
				SignDigitsRec(file);
				ProductsOfTwoNumbersRec(file);
				PrimeNumbersRec(file);
				CombinationsRec(file);
				SumDivideEtImpera(file);
				HighestCommonDenominatorDivideEtImpera(file);

				Console.WriteLine("Done");
			}
		}

		public static void BaseChange(int nr, int b)
		{
			int s = 0;
			while (nr > 0)
			{
				s++;
				baseArray[s] = nr % b;
				nr /= b;
			}
		}
>>>>>>> Stashed changes

			Stream fileStream = File.Create(@"C:\Users\Public\Logi\Text.txt");
			Stream fileStreamValues = File.Create(@"C:\Users\Public\Logi\TextValues.txt");

			using (System.IO.StreamWriter fileValues = new System.IO.StreamWriter(fileStreamValues))
			{
				using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileStream))
				{

					for (int i = 1; i <= 2500; i++)
					{
						myList = PseudoRandomGenerator(i).ToList();
						myArray = myList.ToArray();

						listToSort = myArray.ToList();


						Console.WriteLine(i);

						file.WriteLine("Random set of " + i + " numbers");
						fileValues.WriteLine("Random set of " + i + " numbers");

						BinarySearchSort(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						BubbleSortAscending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						CombSortAscending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						CombSortDescending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						CountingSort(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						CycleSortAscending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						CycleSortDescending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						GnomeSortAscending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						GnomeSortDescending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						HeapSortAscending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						HeapSortDescending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						InsertionSort(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						MergeSort(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						OddEvenSortAscending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						OddEvenSortDescending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						PigeonHoleSortAscending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						PigeonHoleSortDescending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						QuickSort(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						SelectionSortAscending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						SelectionSortDescending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						ShellSortAscending(listToSort, file, fileValues);
						listToSort = myArray.ToList();
						ShellSortDescending(listToSort, file, fileValues);


						file.WriteLine();
						fileValues.WriteLine();

					}
				}

				Console.WriteLine("Done");
				Console.ReadLine();
			}
		}

		public static void BinarySearchSort(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{

			Stopwatch sw = Stopwatch.StartNew();

			myList.UnbalancedBSTSort();

			sw.Stop();

			fisier.WriteLine("Unbalanced BST Sort Elapsed");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void BubbleSortAscending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.BubbleSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Bubble Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void CombSortAscending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CombSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Comb Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void CombSortDescending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CombSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Comb Sort Descending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void CountingSort(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CountingSort();

			sw.Stop();

			fisier.WriteLine("Counting Sort");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void CycleSortAscending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CycleSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Cycle Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void CycleSortDescending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CycleSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Cycle Sort Descending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void GnomeSortAscending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.GnomeSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Gnome Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void GnomeSortDescending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.GnomeSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Gnome Sort Descending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void HeapSortAscending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.HeapSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Heap Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void HeapSortDescending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.HeapSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Heap Sort Descending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void InsertionSort(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.InsertionSort();

			sw.Stop();

			fisier.WriteLine("Insertion Sort");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void MergeSort(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.MergeSort();

			sw.Stop();

			fisier.WriteLine("Merge Sort");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void OddEvenSortAscending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.OddEvenSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Odd Even Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void OddEvenSortDescending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.OddEvenSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Odd Even Sort Descending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void PigeonHoleSortAscending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.PigeonHoleSortAscending();

			sw.Stop();

			fisier.WriteLine("Pigeon Hole Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void PigeonHoleSortDescending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.PigeonHoleSortDescending();

			sw.Stop();

			fisier.WriteLine("Pigeon Hole Sort Descending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void QuickSort(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.QuickSort();

			sw.Stop();

			fisier.WriteLine("Quick Sort");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void SelectionSortAscending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.SelectionSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Selection Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void SelectionSortDescending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.SelectionSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Selection Sort Descending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void ShellSortAscending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.ShellSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Shell Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static void ShellSortDescending(List<int> myList, StreamWriter fisier = null, StreamWriter fisierValori = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.ShellSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Shell Sort Ascending");
			fisierValori.WriteLine(sw.Elapsed);
		}

		public static IEnumerable<int> PseudoRandomGenerator(int length)
		{
			Random rnd = new Random();

			int ind = 0;
			int[] myArray = new int[length];

			while (ind < length)
			{
				myArray[ind] = rnd.Next(1000000);
				ind++;
			}


			return myArray;
		}
	}
}
