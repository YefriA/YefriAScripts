using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Program
    {
        static void Main(string[] args)
        {
            Random cartaAleatoria  = new Random();
            int carta1 = 0, carta2 = 0, cartaEntregar = 0, suma = 0;
            string continuar = "o";

            carta1 = cartaAleatoria.Next(1, 11);
            carta2 = cartaAleatoria.Next(1, 11);
            suma = carta1 + carta2;
            Console.WriteLine("Sus cartas son: " + carta1 + ", " + carta2);
            Console.WriteLine("Lleva: "+suma);
            Console.Write("Quiere sacar una carta más (s/n)? ");
            continuar = Console.ReadLine();

            while (continuar =="s")
            {

                cartaEntregar = cartaAleatoria.Next(1, 11);
                Console.WriteLine("Recogió un: "+ cartaEntregar);
                suma += cartaEntregar;

                if (suma >= 21)
                {
                    continuar = "n";
                }
                else
                {
                    Console.WriteLine("Lleva: " + suma);
                    Console.Write("Quiere sacar una carta más (s/n)? ");
                    continuar = Console.ReadLine();
                }
            }

            if (continuar == "n")
            {
                if (suma > 21)
                    Console.WriteLine("Tienes " + suma + ". Perdiste!");
                else if (suma == 21)
                     Console.WriteLine("EXTRAORDINARIO, tienes: " + suma);
                else
                    Console.WriteLine("Obtuviste un: " + suma + " ¿Estuvo cerca a 21?");
            }

        }
    }
}
