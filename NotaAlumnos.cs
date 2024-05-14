using System;

namespace NotasAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            int NotaAlta, NotaBaja, x, nota;
            string linea;
            NotaAlta = 0;
            NotaBaja = 0;
            x = 1;

            while (x <= 10) 
            {
                Console.Write("Ingrese una nota: ");
                linea = Console.ReadLine();
                nota = int.Parse(linea);

                if (nota >= 7)
                {
                    NotaAlta = NotaAlta + 1;

                }

                else
                {
                    NotaBaja = NotaBaja + 1;
                }
                x = x + 1;
            }
            Console.Write($"La Cantidad de Alumnos mayores o igual a 7 son: ");
            Console.WriteLine(NotaAlta);
            Console.Write($"La Cantidad de Alumnos menores o igual a 7 son: ");
            Console.WriteLine(NotaBaja);
            Console.ReadKey();
        }

        }
    }


