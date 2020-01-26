using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ej3
    {
        static void Main()
        {
            Console.WriteLine("Digite W, X y el ángulo D");

            double w = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double dGrad = double.Parse(Console.ReadLine());

            double dRad = dGrad * (Math.PI/180);

            double y = (w * Math.Cos(dRad)) - x;

            Console.WriteLine("Y= " + y);
        }
    }
}
