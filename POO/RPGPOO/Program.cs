
using RPGPOO.classes;

Personagem persona = new Personagem();

Console.WriteLine($"Bem vindo ao nosso RPG ;)");


Console.Write($"Informe o nome do personagem: ");
persona.Nome = Console.ReadLine();


Console.Write($"Informe a idade do personagem:");
persona.Idade = int.Parse(Console.ReadLine()!);

Console.Write($"Informe a IA do seu personagem:");
persona.IA = Console.ReadLine();


Console.Write($"Informe a armadura do seu personagem:");
persona.Armadura = Console.ReadLine();

Console.WriteLine($"{persona.Nome}");
Console.WriteLine($"{persona.Idade}");
Console.WriteLine($"{persona.IA}");
Console.WriteLine($"{persona.Armadura}");

Console.WriteLine();


persona.Atacar();
Console.WriteLine();

Console.WriteLine($"O inimigo te atacou {persona.Nome} !!!!");
Console.WriteLine();

persona.Defender();
Console.WriteLine();

Console.WriteLine($"Sua armadura esta destruida :( :0");
Console.WriteLine();

persona.RestaurarArmadura();
