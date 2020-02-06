using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicoEjercico
{
    class Sem3
    {
        static void Main()
        {

            Console.WriteLine("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("blancos= ");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("anulados= ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Total Poblacion= ");
            double totalPoblacion = double.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje mayo de edad= ");
            double porcentaje = double.Parse(Console.ReadLine());

            double votosTotales = (a + b + blancos + anulados);

            double diferencia = 0;

            if (a > b)
                diferencia = a - b;
            else
                diferencia = b - a;

            bool primer = votosTotales > totalPoblacion;
            bool segundo = diferencia < (votosTotales * 0.1);
            bool tercero = votosTotales < (totalPoblacion * 0.3);


            if ((primer || segundo) && tercero)
                Console.WriteLine("Toca Repetir");
            else if (a > b)
                Console.WriteLine("Ganador es A");
            else
                Console.WriteLine("Ganador es B");
        }
    }
}
