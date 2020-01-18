using System;

namespace Ejercicio_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada = "";
            int Contador = 0, Mayor = 0, Menor = 0, Opcion=0, Edad = 0, Sumatoria = 0;
            float Promedio = 0;

            Console.Write("Ingresar Cantidad de Personas a Poner Edad: ");
            Entrada = Console.ReadLine();
            Contador = Convert.ToInt32(Entrada);

            Console.Write("Ingresar Edad de la Persona {0}: ", 1);
            Entrada = Console.ReadLine();
            Edad = Convert.ToInt32(Entrada);
            Sumatoria += Edad;
            Menor = Edad;
            Mayor = Edad;
            Promedio = Edad;

            if(Contador <= 1)
            {
                Console.WriteLine("El Promedio Es: {0}", Promedio);
                Console.WriteLine("El Mayor Es: {0}", Mayor);
                Console.WriteLine("El Menor Es: {0}", Menor);
            }

            if (Contador > 1)
            {
                for (int i = 1; i < Contador; i++)
                {
                    Console.Write("Ingresar Edad de la Persona {0}: ", i + 1);
                    Entrada = Console.ReadLine();
                    Edad = Convert.ToInt32(Entrada);
                    Sumatoria += Edad;

                    if (Edad < Menor)
                        Menor = Edad;
                    if (Edad > Mayor)
                        Mayor = Edad;

                    Promedio = Sumatoria / Contador;
                }

                Console.WriteLine("El Promedio Es: {0}", Promedio);
                Console.WriteLine("El Mayor Es: {0}", Mayor);
                Console.WriteLine("El Menor Es: {0}", Menor);
            }
        }
    }
}
