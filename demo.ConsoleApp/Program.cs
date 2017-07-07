using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Shapes;

namespace demo.ConsoleApp
{
	class Program
	{
		//Private
		private int num = 10;
		public static int getNum()
		{
			return 10;
		}

		static void Main(string[] args)
		{

            Shape s = new Shape(1,2);
			IShape s2 = new Shape();

			Console.WriteLine(s.Area());

            Square sq = new Square(0);

            try
            {
                sq.Area();
            }
            catch (ShapeZeroAreaException e)
            {
                Console.WriteLine(e.Message);
            }
            //good practice to have catch all exception
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

            #region
            List<Shape> shapes = new List<Shape>();
            shapes.Add(s);
            shapes.Add(new Square(4));
            shapes.Add(new Triangle(2,4));
            Console.WriteLine(shapes.Count); // should output 3

            foreach (var item in shapes)
            {
                Console.WriteLine(item.Area());
                //this will give use the shape Area method for Area() instead of using the triangle one
                //will need to caste back to a triangle before using Triangle area method
            }
            #endregion

            List<Shape> findResult = shapes.FindAll(shapeList => shapeList.Area() > 4);
            findResult.Insert(findResult.Count, new Rectangle(4, 6));

        }
    }
}
