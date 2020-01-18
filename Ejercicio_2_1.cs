using System;

namespace Ejercicio_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada;
            float Lado, Distancia, Resultado;

            try
            {
                Console.Write("Ingresar Lado: ");
                Entrada = Console.ReadLine();
                Lado = Convert.ToSingle(Entrada);

                Console.Write("Ingresar Distancia del Poligono: ");
                Entrada = Console.ReadLine();
                Distancia = Convert.ToSingle(Entrada);

                Console.WriteLine("El Resultado del Perimetro del Poligono es: {0}", Resultado = Lado * Distancia);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
