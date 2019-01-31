using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        public static int [] rep(int []  b)
        {
            int[] newar = new int[b.Length * 2];
            for(int i=0, j=0; i<newar.Length; i++, j++)
            {
                newar[i] = b[j];
                i++;
                newar[i] = b[j];
                
            }
            return newar;
        }
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            string s = Console.ReadLine();
            string[] mas = s.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(mas[i]);
            }
            int[] newar = rep(arr);
            for (int i = 0; i < newar.Length; i++)
            {
                Console.Write(newar[i] + " ");
            }
            Console.ReadKey(); 
        } 
    }
}
