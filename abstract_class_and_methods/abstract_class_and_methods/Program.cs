using abstract_class_and_methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {

        static void Main(string[] args)

        {
            Circle myCircle = new(5);
            Rectangle myRectangle = new(4, 6);
            // Display their areas
            Console.WriteLine("Circle Area: {0}", myCircle.GetArea());
            Console.WriteLine("Rectangle Area: {0}", myRectangle.GetArea());
        }

       

        }
    }
