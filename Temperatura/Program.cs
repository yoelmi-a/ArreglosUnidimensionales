using System;

namespace Temperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración del arreglo para 10 días
            double[] temperaturas = new double[10];

            // Entrada de datos
            Console.WriteLine("=== REGISTRO DE TEMPERATURAS (10 DÍAS) ===\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese la temperatura del día {i + 1}: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Procesos
            double tempMaxima = temperaturas[0];
            double tempMinima = temperaturas[0];
            double sumaTemperaturas = 0;
            int diasMayor30 = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                // Temperatura máxima
                if (temperaturas[i] > tempMaxima)
                    tempMaxima = temperaturas[i];

                // Temperatura mínima
                if (temperaturas[i] < tempMinima)
                    tempMinima = temperaturas[i];

                // Suma para promedio
                sumaTemperaturas += temperaturas[i];

                // Días con temperatura mayor a 30°C
                if (temperaturas[i] > 30)
                    diasMayor30++;
            }

            double promedioTemperaturas = sumaTemperaturas / 10;

            // Salidas
            Console.WriteLine("\n=== RESULTADOS ===");
            Console.WriteLine($"Temperatura más alta: {tempMaxima}°C");
            Console.WriteLine($"Temperatura más baja: {tempMinima}°C");
            Console.WriteLine($"Promedio de temperaturas: {promedioTemperaturas:F2}°C");
            Console.WriteLine($"Días con temperatura mayor a 30°C: {diasMayor30}");

            Console.ReadKey();
        }
    }
}