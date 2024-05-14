using System;

namespace FabricadeHierro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de piezas a Procesar: ");
            int cantidadPiezas = Convert.ToInt32(Console.ReadLine());

            int Piezasaptas = 0;

            for (int i = 0; i < cantidadPiezas; i++)
            {
                Console.Write("Ingrese la longitud del perfil {0}: ", i + 1);
                double longitud = Convert.ToDouble(Console.ReadLine());

                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    Piezasaptas++;
                }
            }

            Console.WriteLine($"La cantidad de piezas aptas en el lote es: {Piezasaptas} ");

            Console.ReadKey();
        }
    }
}
    

