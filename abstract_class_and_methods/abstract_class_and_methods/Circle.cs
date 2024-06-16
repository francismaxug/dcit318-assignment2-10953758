using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_and_methods
{
     class Circle:Shape
    {

        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        // Implementation of GetArea() for circle
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
