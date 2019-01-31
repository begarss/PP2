using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        public static int [] rep(int []  b)// создаем метод для изменение массива
        {
            int[] newar = new int[b.Length * 2];// создаем новый массив с размерностью в два раза больше
            for(int i=0, j=0; i<newar.Length; i++, j++)
            {
                newar[i] = b[j];// внесение элемента массива в новый
                i++;// увеливаем индекс нового массива чтобы внесте этот же массив в новый массив второй раз
                newar[i] = b[j];
                
            }
            return newar;// возвращаем новый массив
        }
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());// вводим колво элементов
            int[] arr = new int[a];// массив с размерностью введеного ранее числа
            string s = Console.ReadLine();// вводим наши элементы в линию
            string[] mas = s.Split();// разделяем элементы по пробелу
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(mas[i]);// переносим разделенные элементы в массив инт
            }
            int[] newar = rep(arr);// создаем новый массив и вызываем метод, отправляем в метод наш старый массив
            for (int i = 0; i < newar.Length; i++)
            {
                Console.Write(newar[i] + " ");// выводим новый массив
            }
            Console.ReadKey(); 
        } 
    }
}
