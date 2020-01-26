using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Ej4
    {
        static void Main()
        {
            Console.WriteLine("Digite W, T y el ángulo C");

            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double cGrad = double.Parse(Console.ReadLine());

            double cRad = cGrad * (Math.PI / 180);

            double z = t * Math.Sin(cRad);
            double y = t * Math.Cos(cRad);

            double ab = Math.Acos(z / w);
            double x = (w * Math.Sin(ab)) - y;


            Console.WriteLine("X= " + x);
        }
    }
}
