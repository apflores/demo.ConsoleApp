using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Shapes
{
    public class Pentagon : Shape
    {
        public Pentagon(int length) : base()
        {
            
        }

        public override double Area()
        {
            return (6.8819 * Area()) / 4;
        }
    }
}
