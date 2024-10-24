Console.WriteLine(@"
+-----------------------------+
|    Bem vindo ao programa    |
|    avaliador de produtos    |
+-----------------------------+
");

int homem = 0;
int mulher = 0;
int totalNao = 0;
int totalSim = 0;
int homemnao = 0;
int mulhersim = 0;


for (int p = 1; p <= 10; p++)
{
    Console.WriteLine($"Qual o seu sexo? ");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"Voce gostou do nosso produto lançado? sim/nao");
    string produto = Console.ReadLine()!;

    if (sexo == "feminino")
    {
        mulher++;
    }
    else
    {
        homem++;
    }


    if (produto == "sim")
    {
        totalSim++;
        if (
            sexo == "feminino"
        )
        {
            mulhersim++;
        }
    }
    else
    {
       totalNao++;

       if(sexo == "masculino"){
        homemnao++;
       }
    }

}

float percentual= (100 / homem) * homemnao;

Console.WriteLine($"Total de pessoas que gostaram do produto:{totalSim}");
Console.WriteLine($"Total de pessoas que nao gostaram do produto:{totalNao}");

Console.WriteLine($"Total de mulheres que responderam sim:{mulhersim}");
Console.WriteLine($"porcentagem de homens que responderam nao:{percentual} %");

Console.WriteLine($"Total de mulheres:{mulher}");
Console.WriteLine($"Total de homem:{homem}");