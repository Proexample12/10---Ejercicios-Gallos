//Pide al usuario un número de días e indica
//cuántas semanas completas y cuántos días sobran. Usa operaciones básicas y estructuras if.



namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Introduce un número de días:");
                int dias = int.Parse(Console.ReadLine());
                int semanas = dias / 7;
                int diasSobrantes = dias % 7;
                Console.WriteLine($"Semanas completas: {semanas}, Días sobrantes: {diasSobrantes}");
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }
}
