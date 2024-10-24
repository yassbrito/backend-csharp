Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|         CONTADOR DE PESSOAS          |
+--------------------------------------+
");

//  criar um laco de 10 repeticoes 
// dentro do laco perguntar o sexo da pessoa
// se for homem contar na variavel homem, se for mulher contar na variavel mulher.


int qtdhomem = 0;
int qtdmulher = 0;
int qtdEsportes = 0;
int qtdNaoGostaDeEsportes = 0;
string sexo;
Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qtdDeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual o seu sexo? m/f");
     sexo = Console.ReadLine()!;

    if(sexo == "f"){
        qtdmulher++;
    }else{
       qtdhomem++;
    }  
}

Console.WriteLine($"Voce gosta de esportes? s/n");
string esportes = Console.ReadLine()!;

if (esportes == "s")
{
    qtdEsportes++;
}
else
{
    qtdNaoGostaDeEsportes++;
}
Console.WriteLine($"Quantidade de homem: {qtdhomem}");
Console.WriteLine($"Quantidade de mulher: {qtdmulher}");
Console.WriteLine($"Total de entrevistados: {qtdmulher + qtdhomem}");
Console.WriteLine($"Total de pessoas que gosta de esportes: {qtdEsportes}");
Console.WriteLine($"Total de pessoas que nao gosta de esportes: {qtdNaoGostaDeEsportes}");