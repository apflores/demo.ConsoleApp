using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Shapes
{
    public class ShapeZeroAreaException : Exception
    {
        public ShapeZeroAreaException(string message) : base(message)
        {
        }
    }
}
