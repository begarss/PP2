using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1
{
    class Program
    {
        public static bool Isprime(int n) //Создаем функцию для определение что число прайм
        {
            if (n == 1) // если число равна 1 то выводит фолс так как оно не прайм  
            {
                return false;
            }
            if (n == 2) // если число 2 то это тру
            {
                return true;
            }
            for(int i=2; i<=Math.Sqrt(n); i++) // что проверить число на прайм пробегаемся от  2 до квадратного корня этого числа
            { 
                if (n%i==0) // если наше число делится на первое число из цикла то есть на два то это число уже не прайм
                {
                    return false; // поэтому вывод фолс
                    
                }
            }
            return true; // если наше число не делится с остатком то вывод тру и это число прайм
        }

            static void Main(string[] args)
        {
            int a; 
            a=int.Parse(Console.ReadLine()); // создаем переменную для ввода количество элементов, интеджерге ауыстырамыз
            int[] arr = new int[ a]; // создаем массив с рамзмерностью введенного числа
                string s = Console.ReadLine(); // вводим наши цифры пробелом
                string[] ar = s.Split(); // через сплит помещаем элементы строки в массив строк убирая пробелы
            for (int i = 0; i < a; i++) // каждый элемент из массива строк переводим в массив инт
            {
                arr[i] = int.Parse(ar[i]);
            }
            int cnt=0; // создаем счетчик для праймов
            for (int i = 0; i < arr.Length; i++) // пробегамеся по массиву
            {

                if (Isprime(arr[i])) //если итый элемент массива проверенный через функцию возвращает тру то счетчик увелесиваем
                {
                    cnt = cnt + 1;
                }
            }
            Console.WriteLine(cnt); // выводим количества проаймов
            for (int i = 0; i < arr.Length; i++) { 
            
                if (Isprime(arr[i])) // если элмент прайм то просто выводим его
                {
                    Console.Write(arr[i]+" ");
                }
            }
                    Console.ReadKey(); // для того чтобы консоль не закрылась

        }
    }
}
