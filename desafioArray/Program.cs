int[] numeros = new int[6];
int numeroImpar = 0;
int numeroPar = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite um numero inteiro: "!);
    numeros[i] = int.Parse(Console.ReadLine()!);

    if (numeros[i] % 2 == 0)
    {
        numeroPar++;
    }

    else
    {
        numeroImpar++;
    }
}

Console.WriteLine($"{numeroPar} numeros pares: "!);

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine($"{numeros[i]}");

    }

}

Console.WriteLine($"{numeroImpar} numeros impares: "!);
for (int i = 0; i < numeros.Length; i++)
{
 if (numeros[i] % 2 == 1)
    {
        Console.WriteLine($"{numeros[i]}");

    }
}