using System;

namespace Ejercicio_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada = "";
            int Numero = 0, Resultado = 0;

            Console.Write("Ingresar Numero Para Mostrar Tabla de Multiplicacion: ");
            Entrada = Console.ReadLine();
            Numero = Convert.ToInt32(Entrada);

            for(int i = 1; i <= 10; i++)
            {
                Resultado = Numero * i;

                Console.WriteLine("{0} * {1} = {2}", Numero, i, Resultado);
            }
        }
    }
}
