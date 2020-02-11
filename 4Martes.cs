using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Martes
{
    class Program
    {
        static void Main()
        {
            Console.Write("Su salario mensual es: ");
            int salarioMensual = int.Parse(Console.ReadLine());
            Console.Write("Su tipo de contrato es (1=dependiente, 2=independiente):  ");
            int contrato = int.Parse(Console.ReadLine());

            double baseCotizacion = salarioMensual * 0.4;

            double arl=0, pension=0, eps=0, salarioRealMensual=0, salarioRealAnual=0;

            if (baseCotizacion < 877803)
            {
                baseCotizacion = 877803;
            }

            switch (contrato)
            {
                case 1:
                    arl = 0;
                    pension = 0.04*baseCotizacion;
                    eps = 0.04 * baseCotizacion;

                    salarioRealMensual = salarioMensual - arl - pension - eps;
                    salarioRealAnual = (salarioRealMensual * 12) + salarioMensual;
                    break;
                case 2:
                    Console.Write("Su riesgo es: ");
                    int riesgo=int.Parse(Console.ReadLine());
                    switch (riesgo)
                    {
                        case 1:
                            arl = baseCotizacion * 0.00522;
                            break;
                        case 2:
                            arl = baseCotizacion * 0.01044;
                            break;
                        case 3:
                            arl = baseCotizacion * 0.02436;
                            break;
                        case 4:
                            arl = baseCotizacion * 0.04350;
                            break;
                        case 5:
                            arl = baseCotizacion * 0.06960;
                            break;
                        default:
                            Console.WriteLine("No hay riesgo " + riesgo);
                            break;
                    }

                    pension = 0.16 * baseCotizacion;
                    eps = 0.125 * baseCotizacion;

                    salarioRealMensual = salarioMensual - arl - pension - eps;
                    salarioRealAnual = (salarioRealMensual * 12);
                    break;
                default:
                    Console.WriteLine("Solo admito 1 y 2");
                    break;
            }

            Console.WriteLine("Su salario real mensual es: "+salarioRealMensual+" Su salario real anual es: "+ salarioRealAnual);

        }
    }
}
