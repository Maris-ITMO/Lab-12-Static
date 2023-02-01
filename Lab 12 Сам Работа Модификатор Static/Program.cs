using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Сам_Работа_Модификатор_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = Convert.ToDouble(Console.ReadLine());

            double squae = Circle.GetSquare(radius);
            double perimeter = Circle.Length(radius);
            Console.WriteLine($"{squae} \n{perimeter}");
            Console.ReadKey();


            if (Circle.ContainsPoint(10, 10, 5, 5, 20))
            {
                Console.WriteLine("точки X и Y находятся внутри окружности");
            }
            else
            {
                Console.WriteLine("точки X и Y находятся вне окружности");
            }
            Console.ReadLine();
        }
    }
}
