using System;

namespace InversionArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración del arreglo para 6 números
            int[] numeros = new int[6];

            // Entrada de datos
            Console.WriteLine("=== INVERSIÓN DE ARREGLO ===\n");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Mostrar arreglo original
            Console.WriteLine("\nArreglo original:");
            Console.Write("[ ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]);
                if (i < numeros.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" ]");

            // Proceso: Inversión del arreglo
            int[] numerosInvertidos = new int[6];
            for (int i = 0; i < numeros.Length; i++)
            {
                numerosInvertidos[i] = numeros[numeros.Length - 1 - i];
            }

            // Salida: Arreglo invertido
            Console.WriteLine("\nArreglo invertido:");
            Console.Write("[ ");
            for (int i = 0; i < numerosInvertidos.Length; i++)
            {
                Console.Write(numerosInvertidos[i]);
                if (i < numerosInvertidos.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" ]");

            Console.ReadKey();
        }
    }
}