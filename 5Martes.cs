using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Martes
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, suma = 0, turno = 0, anterior = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                anterior = dado;
                dado = aleatorio.Next(1,13);
                turno += 1;
                suma += dado;

                if (dado%2 == 0)
                {

                    if (suma >= 100)
                    {
                        Console.WriteLine("Sacó: " + dado + ". Lleva: " + suma+". Ganó.");
                        continuar = "n";
                    }
                    else if (dado == 12 && anterior == 10)
                    {
                        Console.WriteLine("Sacó: "+dado+ " y el anterior fue " + anterior + ". Ganó.");
                        continuar = "n";
                    }
                    else
                    {
                        Console.WriteLine("Saco: " + dado + ". Lleva: " + suma);
                        Console.WriteLine("Desea tirar el dado de nuevo (s/n)?: ");
                        continuar = Console.ReadLine();
                    }
                }
                else
                {
                    if (turno > 3)
                    {
                        Console.WriteLine("Sacó: " + dado + ". Es impar, perdió.");
                        continuar = "n";
                    }
                    else
                    {
                        Console.WriteLine("Saco: " + dado + ". Lleva: " + suma);
                        Console.WriteLine("Desea tirar el dado de nuevo (s/n)?: ");
                        continuar = Console.ReadLine();
                    }
                }
            }
        }
    }
}
