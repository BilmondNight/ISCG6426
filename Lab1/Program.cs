using System;
using System.Diagnostics;

namespace Lab1_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Select your function:
1-Linear Search
2-Binary Search
3-Bubble Sort
4-Quicksort");
            string input = Console.ReadLine();

            TimeSpan[] elapsedTimes = new TimeSpan[4]; // elapsed times
            int[] inputLengths = { 100, 1000, 10000, 100000}; // test lengths
            int[] testArrayRandom; // test values for Linear Search, Bubble Sort, and Quicksort
            int[] testArrayInteger; // test values for Binary Search
            Console.WriteLine("Beginning tests...");

            var watch = Stopwatch.StartNew(); // start the timer

            /// loop over the test lengths
            for (int i = 0; i < inputLengths.Length; i++)
            {
                testArrayRandom = new int[inputLengths[i]];
                FillRandom(testArrayRandom, 1, 2000);

                testArrayInteger = new int[inputLengths[i]];
                FillInteger(testArrayInteger);
                
                int search = new Random().Next(1, 2000); // random number for searching
                
                watch.Restart(); // restart the timer
                Console.Write("Running function with {0} length...", inputLengths[i]);

                switch (input)
                {
                    case "1":
                        LinearSearch(testArrayRandom, search);
                        break;
                    case "2":
                        BinarySearch(testArrayInteger, search);
                        break;
                    case "3":
                        BubbleSort(testArrayRandom);
                        break;
                    case "4":
                        Quicksort(testArrayRandom);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        return;
                }
      
                elapsedTimes[i] = watch.Elapsed; // save the time taken to perform
                Console.WriteLine("Function completed execution.");
            }

            /// print out the results for the tests
            Console.WriteLine("\nFinished tests... Results below:\n");
            for (int i = 0; i < elapsedTimes.Length; i++)
            {
                Console.WriteLine("iterations: {0:0000000}\t Elapsed Time: {1}", inputLengths[i], elapsedTimes[i]);
            }
        }

        /// Sets all elements of an array to a random number within the specified min and max values
        public static void FillRandom(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }

        public static void FillInteger(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }

        public static int LinearSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    Console.WriteLine("Found value({0}) at index {1} with the iteration of {2}.", value, i, i + 1);
                    return i + 1;
                }
            }
            Console.WriteLine("failed to find value({0}) in array", value);
            return -1;
        }

        public static int BinarySearch(int[] array, int value)
        {
            int min = 0;
            int max = array.Length - 1;
            int counter = 0; // iteration counter
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (value == array[mid])
                {
                    counter++;
                    Console.WriteLine("Found value({0}) at index {1} with the iteration of {2}.", value, mid, counter);
                    return counter;
                }
                else if (value < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
                counter++;
            }
            Console.WriteLine("failed to find value({0}) in array", value);
            return -1;
        }

        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++) // look through the array
            {
                bool isSwap = false; // reset after each bubble loop

                // bubble loop, the last value not need to check
                for (int j = 0; j < array.Length - 1; j++) {

                    // let the bigger value move right
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1); // call function
                        isSwap = true; // if swap, do not break
                    }
                }

                // early finish if no swaps were made
                if (!isSwap)
                {
                    break;
                }
            }

            // test output after sorting
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}
        }

        public static void Quicksort(int[] array)
        {
            Quicksort(array, 0, array.Length - 1);

            // test output after sorting
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}
        }

        // Quicksort overload
        public static int[] Quicksort(int[] array, int lower, int upper)
        {
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);
                Quicksort(array, lower, p); // sorting the lower part
                Quicksort(array, p + 1, upper); // sorting the upper part
            }
            return array;
        }

        // find out the pivot
        public static int Partition(int[] array, int lower, int upper)
        {
            int i = lower;
            int j = upper;
            int pivot = array[(lower + upper) / 2];

            while (i <= j)
            {
                // lower value move right until it hits the pivot
                while (array[i] < pivot)
                    i++;

                // upper value move left until it hits the pivot
                while (array[j] > pivot)
                    j--;

                // return when lower >= upper
                if (i >= j)
                    return j;

                // if not, swap
                Swap(array, i, j);
                i++;
                j--;
            }
            return j;
        }

        // swap function used for sorting
        public static void Swap<T>(T[] array, int a, int b) where T : IComparable
        {
            T temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
