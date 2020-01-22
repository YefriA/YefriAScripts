using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo2
{
    class Ejercicio2
    {
        static void Main()
        {
            Console.WriteLine("Ingrese valores T y A (en grados)");
            double t = double.Parse(Console.ReadLine());
            double aGrad = double.Parse(Console.ReadLine());

            double aRad = aGrad * Math.PI / 180;

            double y = t * Math.Sin(aRad);
            double z = t * Math.Cos(aRad);

            double c = 90 - aGrad;

            Console.WriteLine("Los catetos tienen un valor de " + y + " y " + z + ". El ángulo desconocido tiene un valor de " + aGrad);
        }
    }
}
