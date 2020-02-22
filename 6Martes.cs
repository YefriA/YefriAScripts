using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de jugadores (mínimo 2 , máximo 5) ");
        int n = int.Parse(Console.ReadLine());
        int jugador = 0;
        int mayor = 0;
        int ganador = 0;

        while (n > 5 || n < 2)
        {
            Console.WriteLine("Error. Ingrese el número de jugadores ");
            n = int.Parse(Console.ReadLine());
        }

        while (jugador < n)
        {
            Console.WriteLine("\n\n\nEstá jugando el jugador " + (jugador + 1));
            Random cartaAleatoria = new Random();
            int carta1 = 0, carta2 = 0, cartaEntregar = 0, suma = 0;
            string continuar = "n";

            carta1 = cartaAleatoria.Next(1, 11);
            carta2 = cartaAleatoria.Next(1, 11);
            suma = carta1 + carta2;
            Console.WriteLine("Sus cartas son: " + carta1 + ", " + carta2);
            Console.WriteLine("Lleva: " + suma);
            Console.Write("Quiere sacar una carta más (s/n)? ");
            continuar = Console.ReadLine();
            while (continuar != "s" && continuar != "n")
            {
                Console.WriteLine("Error. Recuerde que es s/n");
                continuar = Console.ReadLine();
            }

            while (continuar == "s")
            {
                cartaEntregar = cartaAleatoria.Next(1, 11);
                Console.WriteLine("Recogió un: " + cartaEntregar);
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
                    while (continuar != "s" && continuar != "n")
                    {
                        Console.WriteLine("Error. Recuerde que es s/n");
                        continuar = Console.ReadLine();
                    }
                }
            }

            if (continuar == "n")
            {
                if (suma > 21)
                {
                    Console.WriteLine("Tienes "+ suma + ", es más de 21. Perdiste!");
                    suma = 0;
                }
                else if (suma == 21)
                    Console.WriteLine("EXTRAORDINARIO, tienes: " + suma);
                else
                    Console.WriteLine("Obtuviste un: " + suma + " ¿Estuvo cerca a 21?");
            }

            Console.WriteLine("Gracias por participar.");
            if (mayor < suma)
            {
                mayor = suma;
                ganador = jugador;
            }

            jugador++;
        }

        if (mayor==0)
        {
            Console.WriteLine("\n\n\nNadie ganó");
        }
        else
            Console.WriteLine("\n\n\nGanó el jugador "+(ganador+1)+" con "+ mayor +" puntos!");

    }

}
