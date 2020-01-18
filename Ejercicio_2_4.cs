using System;

namespace Ejercicio_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada = "";
            int Celcius = 0; 
            float Resultado = 0;

            try
            {
                Console.Write("Ingresar Grados Centrigados a Covertir: ");
                Entrada = Console.ReadLine();
                Celcius = Convert.ToInt32(Entrada);

                Resultado = (Celcius * 1.8f) + 32;

                Console.WriteLine("{0} Grados Fahrenheit: ", Resultado);
            }
            catch(Exception)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
