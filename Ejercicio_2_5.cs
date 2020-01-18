using System;

namespace Ejercicio_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada = "";
            float Dolar = 0;
            float Euro = 0;
            float CambioDolar = 0;
            float CambioEuro = 0;
            try
            {
                Console.Write("Valor del Dolar: ");
                Entrada = Console.ReadLine();
                Dolar = Convert.ToSingle(Entrada);

                Console.Write("Valor del Euro: ");
                Entrada = Console.ReadLine();
                Euro = Convert.ToSingle(Entrada);

                Console.WriteLine("Cambio de Dolar a Euro es: {0}", CambioDolar = Dolar * Euro);
                Console.WriteLine("Cambio de Euro a Dolar es: {0}", CambioEuro = Euro / Dolar);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
