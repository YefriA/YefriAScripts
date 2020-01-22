using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1A
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese valores Z y Y");
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));

            double cRad = Math.Asin(z / t);

            double cGrad = cRad * (180 / Math.PI);

            //La suma de los ángulos internos de un triángulo es igual a 180, recordar que es un triángulo rectángulo por lo que uno de los ángulos es igual a 90grados
            double aGrad = 90 - cGrad;

            Console.WriteLine("La hipotenusa tiene un valor de " + t + ". Los ángulos desconocidos tienen un valor de " + cGrad + " y " + aGrad);
        }
    }
}
