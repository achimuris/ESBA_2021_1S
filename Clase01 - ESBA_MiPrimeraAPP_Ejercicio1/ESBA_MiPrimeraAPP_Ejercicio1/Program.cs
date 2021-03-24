using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESBA_MiPrimeraAPP_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4 = 0;

            float promedio = 0;

            SolicitarNotas(out nota1, out nota2, out nota3, out nota4);
            promedio = CalcularPromedio(nota1, nota2, nota3, nota4);
            ImprimirPromedio(promedio);

            Console.ReadKey();

        }

        private static void ImprimirPromedio(float promedio)
        {
            Console.WriteLine("El promedio es: " + promedio);
        }

        private static float CalcularPromedio(int nota1, int nota2, int nota3, int nota4)
        {
            return (float)(nota1 + nota2 + nota3 + nota4) / (float)4;
        }

        private static void SolicitarNotas(out int nota1, out int nota2, out int nota3, out int nota4)
        {
            Console.WriteLine("Ingrese la nota 1: ");

            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 3: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 4: ");
            nota4 = int.Parse(Console.ReadLine());
        }
    }
}
