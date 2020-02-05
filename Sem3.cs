using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicoEjercico
{
    class Program
    {
        static void Main()
        {
            int a, b, blancos, anulados;
            double totalPoblacion;

            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine()); 
            //blancos = int.Parse(Console.ReadLine());
            //anulados = int.Parse(Console.ReadLine());
            //totalPoblacion = double.Parse(Console.ReadLine());

            //double votosTotales = a + b + blancos + anulados;

            //bool primer = votosTotales > totalPoblacion;
            //bool segundo = (a - b) < (votosTotales * 0.1);
            //bool tercero = votosTotales < (totalPoblacion * 0.3);

            bool primer = true;
            bool segundo= true;
            bool tercero = true; 

            if ((primer || segundo) && tercero)
                Console.WriteLine("Toca Repetir "+primer + segundo + tercero);
            //else if (a > b)
                //Console.WriteLine("Ganador es A "+primer + segundo + tercero);
            else
                Console.WriteLine("Ganador es B "+primer + segundo + tercero);
        }
    }
}
