namespace Ejericicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite un numero entero: ");
            num = int.Parse(Console.ReadLine()!);
            if (num % 2 == 0)
            {
                Console.WriteLine("Su numero es par");
            }            
            else
            {
                Console.WriteLine("Tu numero es impar");
            }
        }
    }
}    
