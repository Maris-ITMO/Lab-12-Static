using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Сам_Работа_Модификатор_Static
{
    public static class Circle
    {
            public static double Length(double radius)
            {
                return 2 * Math.PI * radius;
            }
            public static double GetSquare(double radius)
            {
                return Math.PI * radius * radius;
            }
            public static bool ContainsPoint(double x, double y, double x0, double y0, double radius)
            {
                double distance = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));
                return distance <= radius;
            }
    }
}
