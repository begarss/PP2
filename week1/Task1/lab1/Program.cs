using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1
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
            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    return false;
                    
                }
            }
            return true;
        }

            static void Main(string[] args)
        {
            int a;
            a=int.Parse(Console.ReadLine());
            int[] arr = new int[ a];
                string s = Console.ReadLine();
                string[] ar = s.Split();
            for (int i = 0; i < a; i++)
            {
                arr[i] = int.Parse(ar[i]);
            }
            int cnt=0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (Isprime(arr[i]))
                {
                    cnt = cnt + 1;
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < arr.Length; i++) { 
            
                if (Isprime(arr[i]))
                {
                    Console.Write(arr[i]+" ");
                }
            }
                    Console.ReadKey();

        }
    }
}
