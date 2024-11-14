using PilaresPOO.classes;
using PilaresPOO.classes.Aprendizagem;

Pessoa joao = new Pessoa();
joao.nome = "Joao";
Console.WriteLine($"{joao.nome} nasceu com {joao.idade} anos.");
Console.WriteLine();

Professor sam = new Professor(1221134);
sam.nome = "Samanta";
sam.idade = 22;

Aluno isaacBorges = new Aluno();

isaacBorges.nome = "Isaac Borges";
isaacBorges.idade = 17;
isaacBorges.matricula = 1234567;
isaacBorges.curso = "Dev";
isaacBorges.media = 7.9f;

//Console.WriteLine($"qual eh o seu nome?");


Carro carro = new Carro();
carro.marca = "Honda";
carro.modelo = "Honda cit";
carro.cor = "preto";
carro.potencia = 1.8f;
carro.qtdPassageiro = 3;
carro.qtdPortas = 4;

Moto moto = new Moto();
moto.marca = "Yamaha";
moto.modelo = "Mt";
moto.cor = "roxa";
moto.potencia = 849f;
moto.qtdPassageiro = 2;

Aviao aviao = new Aviao();
aviao.marca = "Airbus";
aviao.modelo = "Airbus X";
aviao.cor = "branca";
aviao.potencia = 165f;
aviao.qtdPassageiro = 65;
aviao.qtdPortas = 2;

Console.WriteLine($"curso: {isaacBorges.curso}");
Console.WriteLine($"   Professor: {sam.nome}");
Console.WriteLine($"   identificaçao do Professor: {sam.NIF}");
Console.WriteLine();
Console.WriteLine($"Aluno: {isaacBorges.nome}");
Console.WriteLine($"Idade: {isaacBorges.idade}");
Console.WriteLine($"Matricula: {isaacBorges.matricula}");
Console.WriteLine($"media: {isaacBorges.media}");