using System;

namespace SueldoEmpleados
{
     class Program
    {
        static void Main(string[] args)
        {
            int n, x, contador, contador2;
            float sueldo,gastos;
            string linea;
            contador = 0;
            contador2 = 0;
            gastos = 0;
            x = 1;
            Console.Write("¿Cuántos empleados hay? ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                Console.Write("Ingrese el sueldo del empleado: ");
                linea = Console.ReadLine();
                sueldo = float.Parse(linea);
                if (sueldo <= 300)
                {
                    contador = contador + 1;
                }
                else
                {
                    contador2 = contador2 + 1;
                }
                gastos = gastos + sueldo;
                x = x + 1;
            }
            Console.Write("Cantidad de empleados que ganan entre 100 y 300: ");
            Console.WriteLine(contador);
            Console.Write("Cantidad de empleados que ganan más de 300: ");
            Console.WriteLine(contador2);
            Console.Write("Gastos totales de la empresa: ");
            Console.WriteLine(gastos);
            Console.ReadKey();
        }
    }
}
