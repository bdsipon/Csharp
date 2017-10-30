using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
         
            s.PrintName();
        }
    }


    class Student 
    {
        public string Name { get; set; } = "Sipon Hossain";
        public void PrintName()
        {
            Console.WriteLine($"Student name is {Name}.");
        }
    }
}
