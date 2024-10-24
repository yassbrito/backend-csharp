   Console.WriteLine("Infome a quantidade de lado 1 do triangulo");
int lado1Triangulo = int.Parse (Console.ReadLine());

Console.WriteLine("Infome a quantidade de lado 2 do triangulo");
int lado2Triangulo = int.Parse (Console.ReadLine());

Console.WriteLine("Infome a quantidade de lado 3 do triangulo");
int lado3Triangulo = int.Parse (Console.ReadLine());


if (lado1Triangulo == lado2Triangulo && lado2Triangulo == lado3Triangulo ) 
{
Console.WriteLine($"O triangulo eh equilatero");
}

else if(lado1Triangulo == lado2Triangulo || lado1Triangulo == lado3Triangulo || lado2Triangulo==lado3Triangulo)
{
    Console.WriteLine($"O Triangulo eh isoceles");
}

else
{
    Console.WriteLine("O tringulo eh Escaleno");
}