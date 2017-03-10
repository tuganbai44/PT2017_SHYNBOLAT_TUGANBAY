using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] arr = new int[s.Length];
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[i] - 48;
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}


