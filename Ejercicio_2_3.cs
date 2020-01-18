using System;

namespace Ejercicio_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.14f;
            string Entrada = "";
            float Grados = 0, Radian = 0;
            try
            {
                Console.Write("Ingresar Grados: ");
                Entrada = Console.ReadLine();
                Grados = Convert.ToSingle(Entrada);

                Radian = (Grados * PI) / 180;

                Console.WriteLine("En Radia Es: {0}", Radian);

            }
            catch(Exception e)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
