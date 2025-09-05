//Crea un programa que pida al usuario una contraseña
//y repita la solicitud hasta que ingrese la correcta.
//Usa un bucle do while.



namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese la contraseña:");
            } while (Console.ReadLine() != "redwood");
        }
    }
}
