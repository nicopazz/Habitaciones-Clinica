using System;

namespace Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de vectores y variables
            string[] nombres = new string[10];
            int[] edades = new int[10];

            int suma = 0;
            double promedio = 0;

            //Carga de nombres
            Console.WriteLine("---------- INGRESO DE PACIENTES ----------\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese el nombre del paciente: ");
                nombres[i] = Console.ReadLine();
                Console.Write($"Ingrese la edad del paciente [{nombres[i]}] : ");
                edades[i] = int.Parse(Console.ReadLine());
                suma += edades[i];
            }


            //Calculo de promedio
            promedio = (double)suma / 3;

            Console.WriteLine("\n---------- PACIENTES INGRESADOS ----------\n");

            //Muestro habitacion - nombre - edad de paciente
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Habitacion N° {i + 1} - Nombre: {nombres[i]} - Edad: {edades[i]} ");
            }

            Console.WriteLine("\n---------- PROMEDIO DE EDADES ----------");


            Console.WriteLine($"\nPromedio de edades: {promedio:F2}");

            Console.WriteLine("\n---------- FIN DEL PROGRAMA ----------");

            Console.ReadKey();
        }
    }
}
