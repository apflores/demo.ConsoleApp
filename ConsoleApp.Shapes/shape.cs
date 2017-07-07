using System;

namespace ConsoleApp.Shapes
{
	/// <summary>
	/// Shapes class
	/// </summary>
	public class Shape : IShape
	{
		/// <summary>
		/// constructor
		/// </summary>
		public Shape()
		{
			length = 0;
			// this -> refers to the whole class
			this.width = 0;
		}

		/// <summary>
		/// overloaded constructor
		/// </summary>
		/// <param name="length">int representing shape length</param>
		/// <param name="width">shape width</param>
		public Shape(int length, int width)
		{
			this.length = length;
			this.width = width;
		}

		//fields
		//private by default
		private int length;
		private int width;

        #region method
        //methods
        public virtual double Area()
		{
            if (this.length * this.width == 0)
            {
                throw new ShapeZeroAreaException($"area is 0, length is {length}, width is {width}");
            };
            return this.length * this.width;
		}

        public string GetShapeInfo()
        {
            string result = "";
            //string tripolation
            result = $"length is {length} and width is {width}";
            return result;
        }
        #endregion method
    }
}