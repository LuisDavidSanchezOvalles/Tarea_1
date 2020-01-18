using System;

namespace Ejercicio_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada = "";
            int Numero = 0;
            try
            {
                Console.Write("Ingresar Numero Para Determinar si es Par o Impar: ");
                Entrada = Console.ReadLine();
                Numero = Convert.ToInt32(Entrada);

                if (Numero == 0)
                {
                    Console.WriteLine("El Numero: {0} es Neutro", Numero);
                }

                if (Numero != 0 && Numero % 2 == 0)
                {
                    Console.WriteLine("El Numero: {0} es Par", Numero);
                }
                else if(Numero != 0 && Numero % 2 != 0)
                {
                    Console.WriteLine("El Numero: {0} es Impar", Numero);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
