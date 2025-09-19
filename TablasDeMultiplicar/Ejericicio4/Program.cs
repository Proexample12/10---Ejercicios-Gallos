namespace Ejericicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, multiplo, producto;
            multiplo = 1;
           
            Console.Write("Digite un numero entero: ");
            num=int.Parse(Console.ReadLine()!);
            do
            {
                producto = num * multiplo;
                Console.WriteLine(num + " x " + multiplo + "= "+ producto);
                multiplo = multiplo + 1;
            }while(multiplo < 11);
            
        }
    }
}
