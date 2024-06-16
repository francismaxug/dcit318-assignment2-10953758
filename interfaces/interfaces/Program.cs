using interfaces;
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
                // Create instances of Car and Bicycle
                Car myCar = new Car();
                Bicycle myBicycle = new Bicycle();
                // Call Move() on each instance
                myCar.Move();
                myBicycle.Move();
            }
        

   
        }
    }
