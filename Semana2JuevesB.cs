using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves2
{
    class Semana2JuevesB
    {
        static void Main()
        {
            Console.WriteLine("digite su salario");
            int sal = int.Parse(Console.ReadLine());

            if (sal < 2 * 877803) {
                Console.WriteLine("Usted tiene tarifa A y el valor de las cuotas moderadoras es de 3400 pesos");
            }
            else if (sal < 5 * 877803) {
                Console.WriteLine("Usted tiene tarifa B y el valor de las cuotas moderadoras es de 13500 pesos");
            }
            else {
                Console.WriteLine("Usted tiene tarifa C y el valor de las cuotas moderadoras es de 35600 pesos");}


        }
    }
}
