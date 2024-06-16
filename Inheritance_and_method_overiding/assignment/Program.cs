
using assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Method_Overriding
{
    internal class Program
    {

        static void Main(string[] args)

        {
                Animal animal = new();
                Dog dog = new();
                Cat cat = new();
                dog.MakeSound();
                animal.MakeSound();
                cat.MakeSound();
           
                Console.ReadKey();
        }

      
    }
}