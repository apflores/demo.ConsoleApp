using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Shapes
{
    public class Triangle: Shape
    {

        /// <summary>
        /// overloaded base constructor
        /// </summary>
        public Triangle()
        {
            length = 0;
            width = 0;
        }

        /// <summary>
        /// overloaded base constructor
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Triangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        //fields
        private int length;
        private int width;

        //methods
        public double Area(int length, int width)
        {
            return (double) base.Area() / 2;
        }
    }
}
