using System;

namespace VentasDiarias
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración del arreglo para 7 días
            double[] ventas = new double[7];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            // Entrada de datos
            Console.WriteLine("=== REGISTRO DE VENTAS SEMANALES ===\n");
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese las ventas del {dias[i]}: $");
                ventas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Procesos
            double totalSemana = 0;
            double ventaMaxima = ventas[0];
            int diaMaximo = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                totalSemana += ventas[i];

                if (ventas[i] > ventaMaxima)
                {
                    ventaMaxima = ventas[i];
                    diaMaximo = i;
                }
            }

            double promedioDiario = totalSemana / 7;

            // Salidas
            Console.WriteLine("\n=== RESULTADOS ===");
            Console.WriteLine($"Total vendido en la semana: ${totalSemana:F2}");
            Console.WriteLine($"Promedio diario: ${promedioDiario:F2}");
            Console.WriteLine($"Día con venta máxima: {dias[diaMaximo]} (${ventaMaxima:F2})");

            Console.ReadKey();
        }
    }
}