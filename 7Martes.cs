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
        int mayor = 0, ganador = 0, segundo = 0, jugadorSeg = 0;
        int[] puntajes = new int[n];
        int[] jugador = new int[n];

        while (n > 5 || n < 2)
        {
            Console.WriteLine("Error. Ingrese el número de jugadores ");
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            jugador[i] = i + 1;
            Console.WriteLine("\n\n\nEstá jugando el jugador " + jugador[i]);
            Random cartaAleatoria = new Random();
            int carta1 = 0, carta2 = 0, cartaEntregar = 0;
            string continuar = "n";


            carta1 = cartaAleatoria.Next(1, 11);
            carta2 = cartaAleatoria.Next(1, 11);
            puntajes[i] = carta1 + carta2;
            Console.WriteLine("Sus cartas son: " + carta1 + ", " + carta2);
            Console.WriteLine("Lleva: " + puntajes[i]);
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
                puntajes[i] += cartaEntregar;

                if (puntajes[i] >= 21)
                {
                    continuar = "n";
                }
                else
                {
                    Console.WriteLine("Lleva: " + puntajes[i]);
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
                if (puntajes[i] > 21)
                {
                    Console.WriteLine("Tienes " + puntajes[i] + ", es más de 21. Perdiste!");
                    puntajes[i] = 0;
                }
                else if (puntajes[i] == 21)
                    Console.WriteLine("EXTRAORDINARIO, tienes: " + puntajes[i]);
                else
                    Console.WriteLine("OBTUVISTE EN TOTAL UN: " + puntajes[i]);
            }
           
           Console.WriteLine("Gracias por participar.");

            if (mayor < puntajes[i])
            {
                mayor = puntajes[i];
                ganador = jugador[i];
            }

        }

        if (mayor == 0)
        {
            Console.WriteLine("\n\n\nNadie ganó");
        }
        else
        {

            for (int i = 0; i < n; i++)
            {
                if (segundo < puntajes[i] && puntajes[i]!=mayor)
                {
                    segundo = puntajes[i];
                    jugadorSeg = jugador[i];
                }
            }

            Console.WriteLine("\n\n\nGanó el jugador " + ganador + " con " + mayor + " puntos!");

            if (segundo == 0)
            {
                Console.WriteLine("No hay segundo lugar");
            }
            else
                Console.WriteLine("El segundo es el jugador "  + jugadorSeg + " con " + segundo + " puntos!");
        }


    }

}
