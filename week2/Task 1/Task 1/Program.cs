using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Task_1
{
    class Program
    {
        public static bool poli(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;  
                    j--;
            }
            return true;
        }
       
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            String s = sr.ReadToEnd();
            if (poli(s))
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
