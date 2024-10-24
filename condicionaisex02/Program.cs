Console.WriteLine(@$"
+-----------------------------------------+
|                futebol                  |
+-----------------------------------------+
|                 Ola :)                  |
|              resultfut                  |
+-----------------------------------------+");
 
 //entrada de gols
 int golsTimeA;
 int golsTimeB;

 Console.WriteLine($"Entre com a quantidade de gols do time A");
 golsTimeA = int.Parse(Console.ReadLine()!);
 Console.WriteLine($"Entre com a quantidade de gols do time B");
 golsTimeB = int.Parse(Console.ReadLine()!);

if (golsTimeA > golsTimeB)
{
    Console.WriteLine($"A vitoria he do time A");
}
else if(golsTimeA < golsTimeB)
{
    Console.WriteLine($"A vitoria eh do time B");
}
else
{
    Console.WriteLine($"o resultado foi empate");
}
