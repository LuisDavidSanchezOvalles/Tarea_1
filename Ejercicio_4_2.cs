using System;

namespace Ejercicio_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada;
            int Base = 0, Exponente = 0, Resultado = 1, Contador = 1;

            Console.Write("Ingresar Base: ");
            Entrada = Console.ReadLine();
            Base = Convert.ToInt32(Entrada);

            Console.Write("Ingresar Exponente: ");
            Entrada = Console.ReadLine();
            Exponente = Convert.ToInt32(Entrada);

            if(Exponente == 0)
            {
                Console.WriteLine("El resultado es: 1");
            }
            else if(Exponente == 1)
            {
                Console.WriteLine("El resultado es: {0}", Base);
            }
            else
            {
                do
                {
                    Resultado = Resultado * Base;
                    Contador++;

                } while (Contador <= Exponente);

                Console.WriteLine("El resultado es: {0}", Resultado);
            }
        }
    }
}
