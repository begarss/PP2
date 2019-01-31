using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {

        public string name;
        public int id;
        public int year=0;

        public Student(string _name, int _id)
        {
            name = _name;
            id = _id;
            year = year + 1;
            
        }
        public void Print()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("ID " + id);
            Console.WriteLine("Year of study " + year);
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Newstudent = new Student("Bekarys", 001);
            Newstudent.Print();
           
        }
    }
}
