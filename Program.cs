using System;

namespace _9_17_lab_sorting {
    class Program {

        /// <summary>
        /// Prints array
        /// </summary>
        /// <param name="array">Array to print</param>
        /// <param name="size">Size of array</param>
        static public void printArray(int[] array, int size) {
            for (uint i = 0; i < size; i++) {
                Console.WriteLine(i + 1 + ": " + array[i]);
            }
        }
        /// <summary>
        /// Sorts the array using selection sort
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        /// <param name="size">Size of array</param>
        static public void selectionSort(int[] array, int size) {
            for (int i = 0; i < size - 1; i++) {
                int min = i;

                for (int j = i + 1; j < size; j++) {
                    if (array[min] > array[j]) {
                        min = j;
                    }
                }

                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }

        static void Main(string[] args) {
            Console.WriteLine("TEST CASE 1\n");
            
            int[] ar = { 4, 5, 1, 3, 8 };
            Console.WriteLine("Before sort of ar");
            printArray(ar, ar.Length);
            selectionSort(ar, ar.Length);
            Console.WriteLine("After sort of ar");
            printArray(ar, ar.Length);

            Console.WriteLine("\nTEST CASE 2\n");

            int[] ar2 = { 1, 2, 3, 4 };
            Console.WriteLine("Before sort of ar2");
            printArray(ar2, ar2.Length);
            selectionSort(ar2, ar2.Length);
            Console.WriteLine("After sort of ar2");
            printArray(ar2, ar2.Length);

            Console.WriteLine("\nTEST CASE 3\n");

            int[] ar3 = { 10, 8, 3, 1, 0 };
            Console.WriteLine("Before sort of ar2");
            printArray(ar3, ar3.Length);
            selectionSort(ar3, ar3.Length);
            Console.WriteLine("After sort of ar2");
            printArray(ar3, ar3.Length);

        }
    }
}