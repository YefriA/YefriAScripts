using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ej2
    {
        static void Main()
        {
            Console.WriteLine("Digite Y y los ángulos D y B");

            double y = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double aGrad = 180 - (d + 90 + b);

            double aRad = aGrad * (Math.PI / 180);

            double z = y / Math.Tan(aRad);

            Console.WriteLine("Z= " + z);
        }
    }
}
