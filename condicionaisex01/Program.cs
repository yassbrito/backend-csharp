Console.WriteLine($"entre com o valor do salario recebido");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"entre com o valor de gasto");
float gasto = float.Parse(Console.ReadLine()!);

if(salario >= gasto)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else
{
    Console.WriteLine($"Orçamento estourado");
}


