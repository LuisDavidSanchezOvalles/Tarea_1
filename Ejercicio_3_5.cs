using System;

namespace Ejercicio_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada = "";
            float Distancia = 0, Area = 0, Perimetro = 0, Apotema = 0;
            int Opcion = 0, Lados = 0;
            try
            {
                Console.WriteLine("Calcular el Poligono regular deseado");
                Console.WriteLine("1. Triangulo Equilatero");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Pentagono");
                Console.WriteLine("4. Hexagono");
                Console.WriteLine("5. Heptagono");
                Console.WriteLine("6. Octagono");
                Console.Write("Opcion: ");

                Entrada = Console.ReadLine();
                Opcion = Convert.ToInt32(Entrada);

                switch(Opcion)
                {
                    case 1:
                        Lados = 3;
                        Console.Write("Longitud de los Lados: ");
                        Entrada = Console.ReadLine();
                        Distancia = Convert.ToSingle(Entrada);
                        Console.Write("Altura del triangulo: ");
                        Entrada = Console.ReadLine();
                        float Altura = Convert.ToSingle(Entrada);

                        Area = (Distancia * Altura) / 2;
                        Perimetro = Lados * Distancia;

                        break;
                    case 2:
                        Lados = 4;
                        Console.Write("Longitud de los Lados: ");
                        Entrada = Console.ReadLine();
                        Distancia = Convert.ToSingle(Entrada);

                        Area = Distancia * Distancia;
                        Perimetro = Distancia * Lados;

                        break;
                    case 3:
                        Lados = 5;
                        Console.Write("Longitud de los Lados: ");
                        Entrada = Console.ReadLine();
                        Distancia = Convert.ToSingle(Entrada);
                        Console.Write("Ingrese el Apotema del Pentagono: ");
                        Entrada = Console.ReadLine();
                        Apotema = Convert.ToSingle(Entrada);

                        Perimetro = Lados * Distancia;
                        Area = (Lados * Distancia * Apotema) / 2;

                        break;
                    case 4:
                        Lados = 6;
                        Console.Write("Longitud de los Lados: ");
                        Entrada = Console.ReadLine();
                        Distancia = Convert.ToSingle(Entrada);
                        Console.Write("Ingrese el Apotema del Hexagono: ");
                        Entrada = Console.ReadLine();
                        Apotema = Convert.ToSingle(Entrada);

                        Perimetro = Lados * Distancia;
                        Area = Lados * Distancia * Apotema;

                        break;
                    case 5:
                        Lados = 7;
                        Console.Write("Longitud de los Lados: ");
                        Entrada = Console.ReadLine();
                        Distancia = Convert.ToSingle(Entrada);
                        Console.Write("Ingrese el Apotema del Heptagono: ");
                        Entrada = Console.ReadLine();
                        Apotema = Convert.ToSingle(Entrada);

                        Perimetro = Lados * Distancia;
                        Area = (Lados * Distancia * Apotema) / 2;
                        break;

                    case 6:
                        Lados = 8;
                        Console.Write("Longitud de los Lados: ");
                        Entrada = Console.ReadLine();
                        Distancia = Convert.ToSingle(Entrada);
                        Console.Write("Ingrese el Apotema del Octagono: ");
                        Entrada = Console.ReadLine();
                        Apotema = Convert.ToSingle(Entrada);

                        Perimetro = Lados * Distancia;
                        Area = Lados * Distancia * Apotema;
                        break;
                    default:
                        Console.WriteLine("Opcion No Valida...");
                        break;
                }

                if(Opcion >= 1 && Opcion <= 6)
                {
                    Console.WriteLine("El Perimetro Es: {0}", Perimetro);
                    Console.WriteLine("El Area es: {0}", Area);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
