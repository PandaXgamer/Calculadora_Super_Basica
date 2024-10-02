using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Eliga una operacion S = Suma, R = Resta, M = Multiplicacion, D = Division");

            string Letra = Console.ReadLine();


            Console.WriteLine("Ingrese el primer numero");


            int numero1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese el Segundo numero");

            int numero2 = Convert.ToInt32(Console.ReadLine());





            switch (Letra)
            {

                case "S":
                    {



                        int sumar = numero1 + numero2;

                    Console.WriteLine($"El Resultado es: {sumar} "); break;


                    }


                case "R":
                    {

                        int restar = numero1 - numero2;
                        Console.WriteLine($"El Resultado es: {restar} "); break;




                    }


                case "M":
                    {

                        int multi = numero1 * numero2;
                        Console.WriteLine($"El Resultado es: {multi} "); break;




                    }
                case "D":
                    {


                        if (numero2 == 0)
                        {
                           Console.WriteLine("No se puede dividir entre 0");
                            break;

                        }
                        else { 
                        int division = numero1 / numero2;
                        Console.WriteLine($"El Resultado es: {division} "); break;
                        }



                    }

                default:
                    {

                        Console.WriteLine("no funciono");
                        break;

                    }
            
            
            }



            Console.ReadKey();


        }
    }
}
