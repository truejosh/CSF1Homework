using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a color");
            string usercolor = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter a car");
            string usercar = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter a book");
            string userbook = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"You entered {usercolor},{usercar},{userbook}");



        }//main
    }//class
}//namespace
