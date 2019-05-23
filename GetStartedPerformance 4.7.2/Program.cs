using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedPerformance_4._7._2
{
	class Program
	{
		//Used for BaseConverter method
		static int[] baseArray = new int[1000000];

		//Used for ProductOfBigNumbers;
		static int[] bigNumber1 = new int[1000000];
		static int[] bigNumber2 = new int[1000000];
		static int[] bigNumberResult = new int[100000000];

		//Used in algorithms for number partitions
		static int[] partitionDialog = new int[100000];
		static int partitionIndex;

		//Used primarily for the addition of the numbers
		static int[] divideEtImperaArray = new int[10000000];

		static void Main(string[] args)
		{
			Stream fileStream = File.Create(@"C:\Users\Public\Logi\Text472.txt");

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

		public static void BaseConverter(StreamWriter fisier = null)
		{
			fisier.WriteLine("Base converter");

			for (int i = 0; i < 1000000; i += 10)
			{
				if (i % 100000 == 0)
				{
					Console.WriteLine(i);
				}
				for (int j = 2; j <= 16; j++)
				{
					Stopwatch sw = Stopwatch.StartNew();

					BaseChange(i, j);

					fisier.WriteLine("From " + i + " to " + j + "  " + sw.Elapsed);

					sw.Stop();
				}
			}

			fisier.WriteLine();
			fisier.WriteLine();

			Console.WriteLine("Done");
		}

		public static void PrimeEuler(StreamWriter fisier = null)
		{
			fisier.WriteLine("Prime Euler");

			int d, Fi, Tmp;
			for (int i = 0; i < 1000000; i++)
			{
				if (i % 10000 == 0)
				{
					Console.WriteLine(i);
				}

				Stopwatch sw = Stopwatch.StartNew();

				Tmp = i;
				Fi = i;
				d = 2;

				while (d <= Tmp)
				{
					if (Tmp % d == 0)
					{
						Fi = Fi * (d - 1) / d;
						while (Tmp % d == 0)
						{
							Tmp /= d;
						}
					}
					else
					{
						if (d == 2)
						{
							d++;
						}
						else
						{
							d += 2;
						}
					}
				}

				sw.Stop();

				fisier.WriteLine(i + " " + sw.Elapsed);
			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static void MaximumArraySum(StreamWriter fisier = null)
		{
			int[] randomNumbers;
			int Smax;

			fisier.WriteLine("Maximum array sum:");

			for (int i = 0; i <= 10000; i++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				randomNumbers = PseudoRandomGenerator(i + 1);

				if (i % 1000 == 0) Console.WriteLine(i);

				Smax = int.MinValue;
				for (int j = 0; j < i; j++)
				{
					for (int k = j + 1; k <= i; k++)
					{
						if (randomNumbers[k] - randomNumbers[j] > Smax)
						{
							Smax = randomNumbers[k] - randomNumbers[j];
						}
					}
				}

				sw.Stop();

				fisier.WriteLine(i + " " + sw.Elapsed);
			}

			fisier.WriteLine();
			fisier.WriteLine();

		}

		public static void NumberOfDigitsUpToN(StreamWriter fisier)
		{
			fisier.WriteLine("Number of digits up to N");

			int rest, i, rnr, coef, exp, nrc = 0, p, ucf;

			Stopwatch sw = Stopwatch.StartNew();

			for (int counter = 0; counter < 100000000; counter++)
			{
				i = counter;

				rest = rnr = p = 0;
				coef = exp = 1;

				while (i != 0)
				{
					ucf = i % 10;
					i /= 10;
					p++;
					nrc = (ucf - 1) * coef + (rnr + 1) * p + rest;
					rnr = ucf * exp + rnr;
					rest += 9 * coef;
					exp *= 10;
					coef = coef * 10 + exp;
				}

				if (counter % 1000000 == 0)
				{
					Console.WriteLine(counter);
				}

			}

			sw.Stop();

			fisier.WriteLine("Number of digits up to N  " + sw.Elapsed);

		}

		public static void ProductOfBigNumbers(StreamWriter fisier)
		{
			fisier.WriteLine("Product of big numbers:");

			int k, v, Tr;
			bigNumberResult[0] = bigNumber1[0];

			for (int counter = 1000; counter <= 10000; counter++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				bigNumber1 = PseudoDigitRandomGenerator(counter);
				bigNumber2 = PseudoDigitRandomGenerator(counter);

				for (int i = 0; i < bigNumber2[0]; i++)
				{
					k = i;
					Tr = 0;
					for (int j = 1; j < bigNumber1[0]; j++)
					{
						v = bigNumberResult[k] + bigNumber2[i] * bigNumber2[j] + Tr;
						bigNumberResult[k] = v % 10;
						Tr = v / 10;
						k++;
					}

					if (Tr > 0)
					{
						bigNumberResult[k] += Tr;
					}
					else
					{
						k--;
					}

					if (k > bigNumberResult[0])
					{
						bigNumberResult[0] = k;
					}
				}


				sw.Stop();

				if (counter % 1000 == 0)
				{
					Console.WriteLine(counter);
				}
				fisier.WriteLine(counter + "  " + sw.Elapsed);
			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static void VietteSums(StreamWriter fisier)
		{
			fisier.WriteLine("Viette sums:");

			Random random = new Random();

			for (int i = 3; i <= 100000; i++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				if (i % 10000 == 0)
				{
					Console.WriteLine(i);
				}

				int a = random.Next(1, 1000);
				int b = random.Next(1, 1000);
				int c = random.Next(1, 1000);

				double Saa, Sa, Sc;
				Saa = -b / a;
				Sa = (-b / a) * (-b / a) - 2 * c / a;

				for (int j = 3; j <= i; j++)
				{
					Sc = -(b * Sa + c * Saa) / a;
					Saa = Sa;
					Sa = Sc;
				}

				sw.Stop();

				fisier.WriteLine(i + " " + sw.Elapsed);
			}

			fisier.WriteLine();
			fisier.WriteLine();

		}

		public static void BinaryCode(StreamWriter fisier)
		{
			fisier.WriteLine("Binary code:");



			int[] x = new int[50];
			long n, nrsol, i, inversionValid;

			for (int counter = 1; counter <= 30; counter++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				for (int count = 0; count < 30; count++)
					x[count] = 0;

				nrsol = 0;
				inversionValid = 1;

				while (inversionValid == 1)
				{
					nrsol++;

					i = counter;
					while ((x[i] == 1) && (i >= 0))
					{
						x[i--] = 0;
					}
					if (i == 0)
					{
						inversionValid = 0;
					}
					else
					{
						x[i] = 1;
					}
				}

				sw.Stop();

				Console.WriteLine(counter + "  " + nrsol);
				fisier.WriteLine(counter + "  " + sw.Elapsed);
			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static void GrayCode(StreamWriter fisier)
		{
			fisier.WriteLine("Gray code:");

			int[] x = new int[20000];
			long nrsol, j, par;

			for (int counter = 1; counter <= 10000; counter++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				for (int count = 0; count < 10000; count++)
					x[count] = 0;
				par = 0;

				nrsol = 0;

				do
				{
					par = 1 - par;
					if (par == 1)
					{
						j = 0;
					}
					else
					{
						j = 1;
						while ((j < counter) && (x[j] == 0))
						{
							j++;
						}

					}

					if (j < counter)
					{
						x[j] = 1 - x[j];
					}

				} while (j < counter);

				sw.Stop();

				fisier.WriteLine(counter + "   " + sw.Elapsed);
				if (counter % 1000 == 0)
				{
					Console.WriteLine(counter + "  " + nrsol);
				}

			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static void Permutation(StreamWriter fisier)
		{
			fisier.WriteLine("Permutation:");

			int[] x = new int[10000000];
			int j;

			for (int counter = 0; counter <= 1000000; counter++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				for (int i = 1; i <= counter; i++)
				{
					x[i] = i;
				}
				j = counter - 1;

				while ((j > 0) && (x[j] > x[j + 1]))
					j--;

				if (j > 0)
				{
					int k = counter;
					while (x[j] > x[k]) k--;

					x[k] = x[k] + x[j];
					x[j] = x[k] - x[j];
					x[k] = x[k] - x[j];

					int len = (counter - 1) / 2;

					for (int m = 0; m < len; m++)
					{
						x[j + m] = x[j + m] + x[counter + 1 - m];
						x[counter + 1 - m] = x[j + m] - x[counter + 1 - m];
						x[counter + m] = x[counter + m] - x[counter + 1 - m];
					}
				}

				sw.Stop();

				fisier.WriteLine(counter + "  " + sw.Elapsed);

				if (counter % 10000 == 0)
				{
					Console.WriteLine(counter);
				}
			}

			fisier.WriteLine();
			fisier.WriteLine();

		}

		public static void Combinations(StreamWriter fisier)
		{
			fisier.WriteLine("Combinations: ");

			int[] x = new int[1000000];
			int counterM, counterN, i, j;
			bool found;

			Stopwatch sw = Stopwatch.StartNew();

			for (counterM = 1; counterM <= 10000; counterM++)
			{
				for (counterN = 1; counterN <= 10000; counterN++)
				{
					for (i = 1; i <= counterM; i++)
					{
						x[i] = i;
					}

					i = counterM;
					found = false;

					while ((i > 0) && (found == false))
					{
						if (x[i] < counterN - counterM + i)
						{
							x[i] = x[i] + 1;
							for (j = i + 1; j <= counterM; j++)
							{
								x[j] = x[j - 1] + 1;
							}

							found = true;
						}
						else
						{
							i--;
						}
					}
					if (found == false)
					{
					}
				}

				if (counterM % 1000 == 0)
				{
					Console.WriteLine(counterM);
				}
			}

			sw.Stop();

			fisier.WriteLine("Combinations: " + sw.Elapsed);

			fisier.WriteLine();
			fisier.WriteLine();

		}

		public static void GeneratePartitions(StreamWriter fisier)
		{
			fisier.WriteLine("Generate partitions");

			for (int i = 1; i <= 25; i++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				partitionIndex = i;
				NumberPartitionGeneration(i, 1);

				sw.Stop();

				fisier.WriteLine(i + "  " + sw.Elapsed);
			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static void GenerateDistinctPartitions(StreamWriter fisier)
		{
			fisier.WriteLine("Generate distinct partitions");

			for (int i = 1; i <= 25; i++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				partitionIndex = i;
				NumberPartitionGenerationDistinct(i, 1);

				sw.Stop();

				fisier.WriteLine(i + "  " + sw.Elapsed);
			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static void NumberPartitionGenerationDistinct(int k, int m)
		{
			int i;

			if (k != 0)
			{
				for (i = 1; i <= k; i++)
				{
					partitionDialog[m] = i;
					if (partitionDialog[m] > partitionDialog[m - 1])
					{
						NumberPartitionGeneration(k - i, m + 1);
					}
				}
			}
		}

		//Used to generate partitions of a number
		public static void NumberPartitionGeneration(int k, int m)
		{
			if (k != 0)
			{
				for (int n = 1; n <= k; n++)
				{
					partitionDialog[m] = n;
					NumberPartitionGeneration(k - n, m + 1);
				}
			}
		}

		public static void DecomposingNtoM(StreamWriter fisier)
		{
			fisier.WriteLine("Decomposing N to M");

			int[,] a = new int[10000, 10000];
			int i, j, k;

			for (int counterN = 1; counterN <= 1000; counterN++)
			{
				for (int counterM = 1; counterM <= 1000; counterM++)
				{
					Stopwatch sw = Stopwatch.StartNew();

					for (i = 1; i <= counterN; i++)
					{
						a[i, 1] = a[i, i] = 1;
					}

					for (i = 3; i <= counterN; i++)
					{
						for (j = 2; j <= i; j++)
						{
							a[i, j] = 0;
							int mn = (i - j < j) ? (i - j) : j;
							for (k = 1; k <= mn; k++)
							{
								a[i, j] += a[i - j, k];
							}
						}
					}

					sw.Stop();

					fisier.WriteLine(counterN + " " + counterM + " " + sw.Elapsed);

				}

				if (counterN % 100 == 0)
				{
					Console.WriteLine(counterN);
				}

			}


			fisier.WriteLine();
			fisier.WriteLine();

		}

		public static void DecomposingNtoMDistinct(StreamWriter fisier)
		{
			fisier.WriteLine("Decomposing N to M distinct");

			int[,] a = new int[10000, 10000];
			int i, j, k, n, m, min, desc;

			for (int counterN = 1; counterN <= 1000; counterN++)
			{
				desc = 0;

				Stopwatch sw = Stopwatch.StartNew();

				for (i = 1; i <= counterN; i++)
				{
					a[i, 1] = a[i, i] = 1;
				}

				for (i = 3; i <= counterN; i++)
				{
					for (j = 2; j < i; j++)
					{
						min = (i - j < j) ? (i - j) : (j);
						for (k = 1; k <= min; k++)
						{
							a[i, j] += a[i - j, k];
						}
					}
				}

				for (i = 1; i <= counterN; i++)
				{
					desc += a[counterN, i];
				}

				sw.Stop();

				fisier.WriteLine(counterN + " " + sw.Elapsed);

			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static void DecomposingNtoPartitions(StreamWriter fisier)
		{
			fisier.WriteLine("Decomposing N to Partitions");

			int[,] s = new int[20000, 20000];
			int n, ds, i, j;
			long np;

			for (int counter = 1; counter < 10000; counter++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				for (i = 1; i <= counter; i++)
				{
					s[i, 1] = s[i, i] = 1;
				}

				for (i = 3; i <= counter; i++)
				{
					for (j = 2; j < i; j++)
					{
						s[i, j] = s[i - 1, j - 1] + j * s[i - 1, j];
					}
				}

				np = 0;

				for (i = 1; i <= counter; i++)
				{
					np += s[counter, i];
				}

				sw.Stop();

				if (counter % 1000 == 0)
				{
					Console.WriteLine(counter);
				}

				fisier.WriteLine(counter + "   " + sw.Elapsed);
			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static void SignDigitsRec(StreamWriter fisier)
		{
			fisier.WriteLine("Sign digits rec:");

			Stopwatch sw = Stopwatch.StartNew();

			for (int counter = 0; counter < Int32.MaxValue; counter++)
			{
				SignDigits(counter);
			}

			sw.Stop();

			fisier.WriteLine("Sign digits took: " + sw.Elapsed);

			fisier.WriteLine();
			fisier.WriteLine();
		}

		//Used to compute the sign digits
		private static int SignDigits(long nr)
		{
			if (nr == 0)
			{
				return 0;
			}
			else
			{
				return 1 + SignDigits(nr >> 1);
			}
		}

		public static void NumbersOfBiggersDigits(StreamWriter fisier)
		{
			fisier.WriteLine("Numbers of bigger digits:");

			Random r = new Random();

			for (int i = 0; i < 100000000; i++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				if (i % 1000000 == 0)
				{
					Console.WriteLine(i);
				}

				Compound(r.Next(1000000), r.Next(1000000));

				sw.Stop();

				if (i % 1000 == 0)
				{
					fisier.WriteLine(i + " " + sw.Elapsed);
				}
			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		//Used for number of bigger digits
		public static long Compound(long x, long y)
		{
			long cif;

			if (x * y == 0)
			{
				return x + y;
			}
			else
			{
				if (x % 10 > y % 10)
				{
					cif = x % 10;
				}
				else
				{
					cif = y % 10;
				}

				return Compound(x / 10, y / 10) * 10 + cif;
			}
		}

		public static void ProductsOfTwoNumbersRec(StreamWriter fisier)
		{
			fisier.WriteLine("Products of two numbers rec:");

			for (int i = 1; i <= 10000; i++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				if (i % 1000 == 0)
				{
					Console.WriteLine(i);
				}

				for (int j = 1; j <= 10000; j++)
				{
					ProductRecAdd(i, j);
				}

				sw.Stop();

				fisier.WriteLine(i + " " + sw.Elapsed);
			}

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static long ProductRecAdd(int x, int y)
		{
			if (y == 0)
			{
				return 0;
			}
			else
			{
				if ((1 & y) == 0)
				{
					return ProductRecAdd(x, y >> 1) << 1;
				}
				else
				{
					return x + ProductRecAdd(x, y >> 1) << 1;
				}
			}
		}

		public static void PrimeNumbersRec(StreamWriter fisier)
		{
			fisier.WriteLine("Prime numbers Rec");

			Stopwatch sw = Stopwatch.StartNew();

			for (long i = 1; i <= 10000000; i++)
			{
				if (i % 1000000 == 0)
				{
					Console.WriteLine(i);
				}

				PrimeRec(i, 3);
			}

			sw.Stop();

			fisier.WriteLine("Prime numbers took: " + sw.Elapsed);

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static int PrimeRec(long nr, long d)
		{
			if ((nr == 2) || (nr == 3))
			{
				return 1;
			}
			else
			{
				if ((nr < 2) || (nr & 1) == 0)
				{
					return 0;
				}
				else
				{
					if (d <= nr / d)
					{
						if (nr % d == 0)
						{
							return 0;
						}
						else
						{
							return PrimeRec(nr, d + 2);
						}
					}
					else
					{
						return 1;
					}
				}
			}
		}

		public static void CombinationsRec(StreamWriter fisier)
		{
			fisier.WriteLine("Combinations Rec");

			Stopwatch sw = Stopwatch.StartNew();

			for (int i = 1; i <= 1000; i++)
			{
				if (i % 100 == 0)
				{
					Console.WriteLine(i);
				}
				for (int j = 1; j <= 1000; j++)
				{
					CombRec(i, j);
				}
			}

			sw.Stop();

			fisier.WriteLine("Combinations rec : " + sw.Elapsed);

			fisier.WriteLine();
			fisier.WriteLine();
		}

		public static long CombRec(int n, int k)
		{
			if ((k == 0) || (k == n))
			{
				return 1;
			}
			else
			{
				return n * CombRec(n - 1, k - 1) / k;
			}
		}

		public static void SumDivideEtImpera(StreamWriter file)
		{
			file.WriteLine("Sum divide et impera");

			long s;


			for (int counter = 1; counter <= 10000; counter++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				divideEtImperaArray = PseudoRandomGenerator(counter + 1);

				s = SumDivEtImp(0, counter);

				sw.Stop();

				file.WriteLine(counter + "  " + sw.Elapsed);

				if (counter % 1000 == 0)
				{
					Console.WriteLine(counter + " " + s);
				}
			}

			file.WriteLine();
			file.WriteLine();
		}

		public static int SumDivEtImp(int Ls, int Ld)
		{
			int sL, Sr, md;
			if (Ls == Ld)
			{
				if (!Prime(divideEtImperaArray[Ls]))
				{
					return divideEtImperaArray[Ls];
				}
				else
				{
					return 0;
				}
			}
			else
			{
				md = (Ls + Ld) / 2;
				sL = SumDivEtImp(Ls, md);
				Sr = SumDivEtImp(md + 1, Ld);

				return sL + Sr;
			}
		}

		public static bool Prime(int nr)
		{
			bool ok;
			int d;

			if ((nr == 2) || (nr == 3))
				return true;
			else
			{
				ok = true;
				for (d = 3; (d <= nr / d) && ok; d += 2)
				{
					if (nr % d == 0)
					{
						ok = false;
					}
				}
			}

			return ok;
		}

		public static void HighestCommonDenominatorDivideEtImpera(StreamWriter file)
		{
			file.WriteLine("Highest common denominator divide et impera");

			long s;

			for (int counter = 1; counter <= 100000; counter++)
			{
				Stopwatch sw = Stopwatch.StartNew();

				divideEtImperaArray = PseudoLCMRandomGenerator(counter + 1);

				s = HighestCommonDenominatorDivEtImpera(0, counter);

				if (counter % 10000 == 0)
				{
					Console.WriteLine(counter + " " + s);
				}

				sw.Stop();

				file.WriteLine(counter + "  " + sw.Elapsed);

			}

			file.WriteLine();
			file.WriteLine();
		}


		public static int BitEuclid(int x, int y)
		{
			int k = 0, r;
			do
			{
				if (x == 0)
				{
					return y << k;
				}
				if (y == 0)
				{
					return x << k;
				}

				while ((x & 1) == 0 && (y & 1) == 0)
				{
					x >>= 1;
					y >>= 1;
					k++;
				}

				r = x % y; x = y; y = r;
			} while (true);
		}

		public static int HighestCommonDenominatorDivEtImpera(int Ls, int Ld)
		{
			int dcS, dcD, md;

			if (Ld - Ls <= 1)
			{
				return BitEuclid(divideEtImperaArray[Ls], divideEtImperaArray[Ld]);
			}
			else
			{
				md = (Ls + Ld) / 2;
				dcS = HighestCommonDenominatorDivEtImpera(Ls, md);
				dcD = HighestCommonDenominatorDivEtImpera(md + 1, Ld);

				return BitEuclid(dcS, dcD);
			}
		}

		public static int[] PseudoRandomGenerator(int length)
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


		//Used for multiplication of big numbers
		public static int[] PseudoDigitRandomGenerator(int length)
		{
			Random rnd = new Random();

			int ind = 0;
			int[] myArray = new int[length];

			while (ind < length)
			{
				myArray[ind] = rnd.Next(10);
				ind++;
			}

			myArray[0] = length - 1;

			return myArray;
		}

		//Used for LCM with a low span of numbers;
		public static int[] PseudoLCMRandomGenerator(int length)
		{
			Random rnd = new Random();

			int ind = 0;
			int[] myArray = new int[length];

			while (ind < length)
			{
				myArray[ind] = rnd.Next(1000);
				ind++;
			}

			myArray[0] = length - 1;

			return myArray;
		}
	}

}
