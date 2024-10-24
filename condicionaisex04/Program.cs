int senha;
int senhaCorreta = 1234;

   Console.WriteLine("Digite a senha");
senha = int.Parse (Console.ReadLine());

if (senha == senhaCorreta)
{
    Console.WriteLine($"ACESSO PERMITIDO.");
}  
else 
{
    Console.WriteLine($"ACESSO NEGADO.");
}
