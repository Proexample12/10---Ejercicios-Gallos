namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Mostrar la fecha actual");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opcion: ");
            opc = int.Parse(Console.ReadLine()!);
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Hola, Bienvenido Profe Duran :D");
                    break;
                case 2:
                    Console.WriteLine($"La fecha actual es {DateTime.Now}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
            }
        }
    }
}
