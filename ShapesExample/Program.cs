using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ShapesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> ShapeList = new List<IShape>();

            ShapeList.Add(new Circle(3));
            ShapeList.Add(new Triangle(7, 4, 4));
            ShapeList.Add(new Circle(10));

            foreach (IShape shape in ShapeList)
            {
                Console.WriteLine(String.Format("{0}: perimeter = {1}, area = {2}", shape.ToString(), shape.GetPerimeter(), shape.GetArea()));
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
