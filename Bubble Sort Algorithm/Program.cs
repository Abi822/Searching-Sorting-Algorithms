using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10000];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("*------------StandardBubbleSort------------*");     
            nums = StandardBubbleSort(nums);
            Display(nums);
            Console.WriteLine("\n---------------------------------------------");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed:{0}ms\n", stopwatch.Elapsed.Milliseconds);

            
            Console.Write("Press any key to continue . . .");
            Console.ReadKey();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("*------------ImprovedBubbleSort------------*");
            nums = ImprovedBubbleSort(nums);
            Display(nums);
            Console.WriteLine("\n---------------------------------------------");
            watch.Stop();
            Console.WriteLine("Time elapsed:{0}ms", watch.Elapsed.Milliseconds);

            Console.WriteLine("\nThe Standard took {0}ms vs Improved took {1}ms", stopwatch.Elapsed.Milliseconds, watch.Elapsed.Milliseconds);
        }
        static int[] StandardBubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        static int[] ImprovedBubbleSort(int[] arr)
        {
            bool swap = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swap = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        swap = true;
                    }
                }
                if (!swap)
                    break;
            }
            return arr;
        }

        static void Display<T>(T[] arr)
        {
            foreach (T x in arr)
            {
                Console.Write(x + " ");
            }
        }
    }

}
