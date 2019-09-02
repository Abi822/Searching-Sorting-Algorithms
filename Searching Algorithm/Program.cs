using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algorithms
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int[] nums = Data();
            foreach (var x in nums)
            {
                Console.Write("{0}\t",x);
            }
            Console.Write("Enter a number you want to find: ");

            if (find<int>(nums, int.Parse(Console.ReadLine())))
                Console.WriteLine("\nNumber was found in the collection");
            else
                Console.WriteLine("\nNumber wasn't found in the collection");
        }
        static int[] Data()
        {
            Random rand = new Random();
            int[] nums = new int[1000000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100, 999);
            }
            return nums;
        }
        static bool find<T>(T[] arr, T val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i].Equals(val))
                    return true;
            }
            return false;
        }


    }
}
