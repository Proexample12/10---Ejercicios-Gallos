Console.WriteLine("Contar 10 numeros pares e impares");
int pares = 0;
int impares = 0;
int cantidad = 10;
int numero;
for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine($"Ingresa el número #{i + 1}:");
     numero = int.Parse(Console.ReadLine()!);
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
