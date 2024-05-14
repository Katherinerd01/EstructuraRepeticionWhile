using System;
using System.Data;

namespace Carga10Valores
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el número {0}: ", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

            double promedio = suma / 10;

            Console.WriteLine($"La Suma de los valores ingresados es: { suma} ");
            Console.WriteLine($"El Promedio de los valores ingresados es: {promedio} ");

            Console.ReadKey();
        }
    }
    

        }
    

