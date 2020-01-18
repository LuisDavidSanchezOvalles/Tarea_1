using System;

namespace Ejercicio_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada = "";
            int Dia;

            try
            {
                Console.Write("Ingresar Numero Para el dia de la semana: ");
                Entrada = Console.ReadLine();
                Dia = Convert.ToInt32(Entrada);

                switch(Dia)
                {
                    case 1:
                        Console.WriteLine("El Dia Seleccionado es: Lunes");
                        break;
                    case 2:
                        Console.WriteLine("El Dia Seleccionado es: Martes");
                        break;
                    case 3:
                        Console.WriteLine("El Dia Seleccionado es: Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("El Dia Seleccionado es: Jueves");
                        break;
                    case 5:
                        Console.WriteLine("El Dia Seleccionado es: Viernes");
                        break;
                    case 6:
                        Console.WriteLine("El Dia Seleccionado es: Sabado");
                        break;
                    case 7:
                        Console.WriteLine("El Dia Seleccionado es: Domingo");
                        break;
                    default:
                        Console.WriteLine("El Dia Seleccionado no Existe");
                        break;
                }
            }catch(Exception)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
