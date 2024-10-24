Console.WriteLine(@"
+-----------------------------------------+
|          Progama de Cadastro            |
+-----------------------------------------+
|                 Ola :)                  |
|      Por favor, digite seus dados       |
+-----------------------------------------+");

Console.WriteLine($"Ola, digite seu nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Ola, {nome}, Agora digite seu Sobrenome:");
string sobrenome = Console.ReadLine()!;

//clw
Console.WriteLine($"Ola seu nome eh: {nome} {sobrenome}");

Console.WriteLine($"Sua data de nascimento eh: ");
string dataDeNascimento = Console.ReadLine()!;

Console.WriteLine($"qual eh o seu email: ");
string email = Console.ReadLine()!;

Console.WriteLine($"qual eh o seu telefone: ");
uint telefone = uint.Parse(Console.ReadLine()!);

Console.WriteLine($"qual eh o seu cpf: ");
uint cpf = uint.Parse(Console.ReadLine()!);

Console.WriteLine($"qual eh o seu endereço: ");
string endereço = Console.ReadLine()!;

//Console.WriteLine($"qual eh a sua idade: ");
//uint idade = uint.Parse(Console.ReadLine()!);

Console.WriteLine($"qual eh o seu estado civil: ");
string EstadoCivil = Console.ReadLine()!;

Console.WriteLine($"Em que ano voce nasceu");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;


Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine($"DataDeNascimento: {DataDeNascimento}");
Console.WriteLine($"email: {email}");
Console.WriteLine($"telefone: {telefone}");
Console.WriteLine($"cpf: {cpf}");
Console.WriteLine($"endereço: {endereço}");
Console.WriteLine($"idade: {idade}");
Console.WriteLine($"EstadoCivil: {EstadoCivil}");
