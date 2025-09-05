//Pide al usuario un número de días e indica
//cuántas semanas completas y cuántos días sobran. Usa operaciones básicas y estructuras if.



namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias;

            if (args.Length > 0)
            {
                
                if (int.TryParse(args[0], out dias))
                {
                    CalcularSemanas(dias);
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido como argumento.");
                }
            }
            else
            {
                
                Console.WriteLine("Introduce un número de días:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out dias))
                {
                    CalcularSemanas(dias);
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                }
            }
        }

        static void CalcularSemanas(int dias)
        {
            int semanas = dias / 7;
            int diasSobrantes = dias % 7;
            Console.WriteLine($"Semanas completas: {semanas}, Días sobrantes: {diasSobrantes}");
        }
    }
}