using System;

namespace Insertion_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 5, 4, 6, 1, 19, 2 };
            int temp,i,j, n=6;

            Console.WriteLine("Insertion sort ");
            Console.Write("Initial array is: ");
            foreach (var item in arr)
            {
                Console.Write(" " +item);
            }

            for ( i = 1; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;

                while(j>=0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j-1;
                }
                arr[j + 1] = temp;
            }
            Console.Write("\n Sorted array is:");
            foreach (var item in arr)
            {
             Console.Write(" "  +item);
            }
            Console.ReadLine();
           
        }


    }
}
