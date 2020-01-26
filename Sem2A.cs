using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2A
{
    class Ej1
    {
        static void Main()
        {
            Console.WriteLine("Digíte el valor de Z, Y y del ángulo B");
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double bGrad = double.Parse(Console.ReadLine());

            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));

            double aRad = Math.Acos(z / t);

            double aGrad = aRad * (180 / Math.PI);

            double dGrad = 180 - 90 - (aGrad + bGrad);

            double dRad = dGrad * (Math.PI / 180);

            double w = z / Math.Sin(dRad);
            double x = (w * Math.Cos(dRad)) - y;

            Console.WriteLine("X= " + x );
        }
    }
}
