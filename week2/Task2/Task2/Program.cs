using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool Isprime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;

                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            string s = sr.ReadLine();
            string[] ar = s.Split();
            int[] arr = new int[ar.Length];
            for (int i = 0; i < ar.Length; i++)
            {
                arr[i] = int.Parse(ar[i]);
            }

            sr.Close();
                    StreamWriter sw = new StreamWriter("output.txt");
            for (int i = 0; i < arr.Length; i++)
            {

                if (Isprime(arr[i]))
                {
                    sw.Write(arr[i] + " ");
                }

            }
            sw.Close();
        }
    }
}
