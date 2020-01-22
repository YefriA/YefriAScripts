using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1tres
{
    class Ejercicio3
    {
        static void Main()
        {
            Console.WriteLine("Ingrese valores C (en grados) y Z");
            double cGrad = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double cRad = cGrad * (Math.PI / 180);

            double y = z / Math.Tan(cRad);
            double t = z / Math.Sin(cRad);

            double a = 90 - cGrad;

            Console.WriteLine("Los catetos tienen un valor de " + y + " y " + t + ". El ángulo desconocido tiene un valor de " + a);
        }
    }
}
