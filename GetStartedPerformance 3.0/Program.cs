using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Algorithms.Sorting;

namespace GetStartedPerformance_3._0
{
	class Program
	{
		static readonly Stopwatch sw = new Stopwatch();
		private static StringBuilder sb = new StringBuilder();

		[DllImport("kernel32.dll")]
		static extern void OutputDebugString(string lpOutputString);

		static void Main(string[] args)
		{
			List<int> myList = null;
			List<int> listToSort = null;
			int[] myArray;

<<<<<<< Updated upstream
			Stream fileStream = File.Create(@"C:\Users\Public\Logi\Text.txt");
=======
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
>>>>>>> Stashed changes

			using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileStream))
			{

				for (int i = 1; i <= 2500; i++)
				{
					myList = PseudoRandomGenerator(i).ToList();
					myArray = myList.ToArray();

					listToSort = myArray.ToList();


					Console.WriteLine(i);
					//sb.AppendLine("Random set of " + i + " numbers");
					file.WriteLine("Random set of " + i + " numbers");

					//Console.WriteLine("Random set of " + i + " numbers");

					//myList = RNGRandomGenerator(100).ToList();



					//pe linie sortarea(tip) , pe coloana nr de elemente , framework pe alt sheet.
					//5000-20000 miercuri 4 A305
					/*
					 * regenerate numbers
					 */

					BinarySearchSort(listToSort, file);
					listToSort = myArray.ToList();
					BubbleSortAscending(listToSort, file);
					listToSort = myArray.ToList();
					CombSortAscending(listToSort, file);
					listToSort = myArray.ToList();
					CombSortDescending(listToSort, file);
					listToSort = myArray.ToList();
					CountingSort(listToSort, file);
					listToSort = myArray.ToList();
					CycleSortAscending(listToSort, file);
					listToSort = myArray.ToList();
					CycleSortDescending(listToSort, file);
					listToSort = myArray.ToList();
					GnomeSortAscending(listToSort, file);
					listToSort = myArray.ToList();
					GnomeSortDescending(listToSort, file);
					listToSort = myArray.ToList();
					HeapSortAscending(listToSort, file);
					listToSort = myArray.ToList();
					HeapSortDescending(listToSort, file);
					listToSort = myArray.ToList();
					InsertionSort(listToSort, file);
					listToSort = myArray.ToList();
					MergeSort(listToSort, file);
					listToSort = myArray.ToList();
					OddEvenSortAscending(listToSort, file);
					listToSort = myArray.ToList();
					OddEvenSortDescending(listToSort, file);
					listToSort = myArray.ToList();
					PigeonHoleSortAscending(listToSort, file);
					listToSort = myArray.ToList();
					PigeonHoleSortDescending(listToSort, file);
					listToSort = myArray.ToList();
					QuickSort(listToSort, file);
					listToSort = myArray.ToList();
					SelectionSortAscending(listToSort, file);
					listToSort = myArray.ToList();
					SelectionSortDescending(listToSort, file);
					listToSort = myArray.ToList();
					ShellSortAscending(listToSort, file);
					listToSort = myArray.ToList();
					ShellSortDescending(listToSort, file);


					//sb.AppendLine(Environment.NewLine);
					//Console.WriteLine();
				}
			}

			Console.WriteLine("Done");
			//Console.WriteLine(sb);
			Console.ReadLine();
		}

		public static void BinarySearchSort(List<int> myList, StreamWriter fisier = null)
		{

			Stopwatch sw = Stopwatch.StartNew();

			myList.UnbalancedBSTSort();

			sw.Stop();

			//OutputDebugString("Unbalanced BST Sort Elapsed - " + sw.Elapsed);
			//Console.WriteLine("Unbalanced BST Sort Elapsed-{0}", sw.Elapsed);
			fisier.WriteLine("Unbalanced BST Sort Elapsed-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Unbalanced BST Sort Elapsed- " + sw.Elapsed);
		}

		public static void BubbleSortAscending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.BubbleSortAscending(Comparer<int>.Default);

			sw.Stop();

			//Console.WriteLine("Bubble Sort Ascending-{0}", sw.Elapsed);
			fisier.WriteLine("Bubble Sort Ascending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Bubble Sort Ascending- " + sw.Elapsed);
		}

		public static void CombSortAscending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CombSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Comb Sort Ascending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Bubble Sort Ascending- " + sw.Elapsed);
		}

		public static void CombSortDescending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CombSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Comb Sort Descending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Comb Sort Descending- " + sw.Elapsed);
		}

		public static void CountingSort(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CountingSort();

			sw.Stop();

			fisier.WriteLine("Counting Sort-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Counting Sort- " + sw.Elapsed);
		}

		public static void CycleSortAscending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CycleSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Cycle Sort Ascending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Cycle Sort Ascending- " + sw.Elapsed);
		}

		public static void CycleSortDescending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.CycleSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Cycle Sort Descending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Cycle Sort Descending- " + sw.Elapsed);
		}

		public static void GnomeSortAscending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.GnomeSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Gnome Sort Ascending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Gnome Sort Ascending- " + sw.Elapsed);

		}

		public static void GnomeSortDescending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.GnomeSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Gnome Sort Descending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Gnome Sort Descending- " + sw.Elapsed);

		}

		public static void HeapSortAscending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.HeapSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Heap Sort Ascending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Heap Sort Ascending- " + sw.Elapsed);
		}

		public static void HeapSortDescending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.HeapSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Heap Sort Descending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Heap Sort Descending- " + sw.Elapsed);
		}

		public static void InsertionSort(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.InsertionSort();

			sw.Stop();

			fisier.WriteLine("Insertion Sort-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Insertion Sort- " + sw.Elapsed);
		}

		public static void MergeSort(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.MergeSort();

			sw.Stop();

			fisier.WriteLine("Merge Sort -{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Merge Sort - " + sw.Elapsed);
		}

		public static void OddEvenSortAscending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.OddEvenSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Odd Even Sort Ascending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Odd Even Sort Ascending- " + sw.Elapsed);

		}

		public static void OddEvenSortDescending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.OddEvenSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Odd Even Sort Descending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Odd Even Sort Descending- " + sw.Elapsed);
		}

		public static void PigeonHoleSortAscending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.PigeonHoleSortAscending();

			sw.Stop();

			fisier.WriteLine("Pigeon Hole Sort Ascending -{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Pigeon Hole Sort Ascending- " + sw.Elapsed);
		}

		public static void PigeonHoleSortDescending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.PigeonHoleSortDescending();

			sw.Stop();

			fisier.WriteLine("Pigeon Hole Sort Descending -{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Pigeon Hole Sort Descending- " + sw.Elapsed);
		}

		public static void QuickSort(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.QuickSort();

			sw.Stop();

			fisier.WriteLine("Quick Sort - {0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Quick Sort - " + sw.Elapsed);
		}

		public static void SelectionSortAscending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.SelectionSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Selection Sort Ascending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Selection Sort Ascending - " + sw.Elapsed);
		}

		public static void SelectionSortDescending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.SelectionSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Selection Sort Descending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Selection Sort Descending - " + sw.Elapsed);
		}

		public static void ShellSortAscending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.ShellSortAscending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Shell Sort Ascending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Shell Sort Ascending - " + sw.Elapsed);
		}

		public static void ShellSortDescending(List<int> myList, StreamWriter fisier = null)
		{
			Stopwatch sw = Stopwatch.StartNew();

			myList.ShellSortDescending(Comparer<int>.Default);

			sw.Stop();

			fisier.WriteLine("Shell Sort Ascending-{0}", sw.Elapsed);
			//Console.WriteLine(sw.Elapsed);
			//sb.AppendLine("Shell Sort Descending - " + sw.Elapsed);

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
