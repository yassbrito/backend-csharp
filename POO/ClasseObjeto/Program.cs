//importando as classes de dentro da pasta classes
using System.Net.Http.Headers;
using ClasseObjeto.Classes;
 
//cria o objeto/variavelbanimal
Animal cachorro = new Animal();
Animal gato = new Animal();

cachorro.nome = "Spaik";
cachorro.raca = "Shittzu";
cachorro.cor = "Preto e Branco";
cachorro.idade = 5;

gato.nome ="Sol";
gato.raca = "viralata";
gato.cor = "Preto e branco";
gato.idade = 10;

Console.WriteLine(); 
Console.WriteLine(); 

Console.WriteLine($"nome do cachorrinho: {cachorro.nome}");
Console.WriteLine($"idade do {cachorro.nome}: {cachorro.idade}");
Console.WriteLine($"cor do {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"raca do {cachorro.nome}: {cachorro.raca}");

Console.WriteLine(); 
Console.WriteLine();

Console.WriteLine($"nome do gatinho: {gato.nome}");
Console.WriteLine($"idade do {gato.nome}: {gato.idade}");
Console.WriteLine($"cor do {gato.nome}: {gato.cor}");
Console.WriteLine($"raca do {gato.nome}: {gato.raca}");

Console.WriteLine(); 
Console.WriteLine();

cachorro.FazerBarulho("au au");
Console.WriteLine($"idade de {cachorro.nome} eh {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"nova idade de {cachorro.nome} eh {cachorro.idade}");

Console.WriteLine();

gato.FazerBarulho("miau miau");
Console.WriteLine($"idade de {gato.nome} eh {gato.idade}");
gato.Envelhecer();
Console.WriteLine($"nova idade de {gato.nome} eh {gato.idade}");