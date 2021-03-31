using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio05_Guia1
{
    class Program
    {
        static void Main(string[] args)
        {

            char caracterIngresado;
            int i = 0;

            while (i < 4)
            {
                Console.WriteLine("Ingrese un caracter:");
                caracterIngresado = char.Parse(Console.ReadLine());

                if (char.IsDigit(caracterIngresado))
                {
                    Console.WriteLine("El caracter ingresado es un número");
                }
                else
                {
                    if (char.IsLetter(caracterIngresado))
                    {
                        if (char.IsLower(caracterIngresado))
                        {
                            Console.WriteLine("Es minúscula");
                        }
                        else
                        {
                            Console.WriteLine("Es mayúscula");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No es ni letra ni un número");
                    }
                }

                i++;
            }


            Console.ReadKey();

        }
    }
}
