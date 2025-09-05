Console.WriteLine("Contar numeros pares e impares");
Console.WriteLine("Ingresa la cantidad de numeros a procesar:");
int cantidad = int.Parse(Console.ReadLine()!);
int pares = 0;
int impares = 0;

for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine($"Ingresa el número #{i + 1}:");
    int numero = int.Parse(Console.ReadLine()!);
    if (numero % 2 != 0)
    {
        impares++;
    }
    else
    {
        pares++;
    }
}

Console.WriteLine($"Cantidad de números pares: {pares}");
Console.WriteLine($"Cantidad de números impares: {impares}");
