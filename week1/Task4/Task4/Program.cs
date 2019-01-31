using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine()); 
            string[,] arr = new string[100,100];
            for (int i = 0; i<a; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    arr[i, j] = "[*]";
                }
            }
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
