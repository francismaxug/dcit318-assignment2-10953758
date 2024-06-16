using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_and_methods
{
     class Rectangle:Shape
    {

        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        // Implementation of GetArea() for rectangle
        public override double GetArea()
        {
            return width * height;
        }
    }
}
