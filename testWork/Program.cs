
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Круг", 5);
            Triangle triangle = new Triangle("Триугольник", 6, 2, 3);
            Console.WriteLine(circle.nameFigur+" "+circle.sqareFigure());
            Console.WriteLine(triangle.nameFigur +" "+ triangle.sqareFigure());

            

        }
    }
}
