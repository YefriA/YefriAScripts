using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1
{
    class JuevesS2A
    {
        static void Main()
        {
            Console.WriteLine("ingrese su salario");
            int sal = int.Parse(Console.ReadLine());

            if (sal < (2 * 877803))
            {
                Console.WriteLine("Tarifa A");
            }
            else if (sal < 4 * 877803)
            {
                Console.WriteLine("Tarifa B");
            }
            else
                Console.WriteLine("Tarifa C");
        }
    }
}
