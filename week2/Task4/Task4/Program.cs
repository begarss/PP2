using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path, path2;
           // Console.WriteLine("Введите путь к файлу и имя");
            path = Console.ReadLine();
            Console.WriteLine("Введите путь куда вы будете копировать и имя файла");
            path2 = Console.ReadLine();
            FileInfo file = new FileInfo(path);
            file.CopyTo(path2);
            file.Delete();



        
        }
    }
}
