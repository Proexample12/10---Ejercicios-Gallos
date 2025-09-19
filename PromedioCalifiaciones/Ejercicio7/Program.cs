namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calif, suma, n,nota;
            double prom;
            n = 1;
            suma = 0;


            Console.Write("Ingrese el numero de clases a promediar: ");
            calif = int.Parse(Console.ReadLine()!);
            if (calif != 0)

            {
                do
                {
                    Console.Write($"Ingrese la nota de la Clase {n}:");
                    n++;
                    nota = int.Parse(Console.ReadLine()!);
                    suma = suma + nota;

                } while (n+1 < calif);
                {
                    prom = suma / calif;
                    Console.WriteLine($"El promedio de las calificaciones ingresadas es de: {prom}");
                }

               
                    
                
            }
            else 
            {
                Console.WriteLine("El numero de asignaturas ingresadas no puede ser igual o menor a 0 ");

            }

            
            
                
            




        }
    }
}

