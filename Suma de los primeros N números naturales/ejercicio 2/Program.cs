namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, suma;
            Console.WriteLine("Suma de los N numoros Naturales");
            Console.WriteLine("Ingrese un numero positivo");
            n = int.Parse(Console.ReadLine()!);
            while (n < 0)
            {
                Console.WriteLine("erre, ingrese un numero positivo");
            }
            while (n > 0)
            {
                suma = n * (n + 1) / 2;
                Console.WriteLine($"La suma de los {n} numeros naturales es {suma}");
                break;

            }

            
        }
    }
}
