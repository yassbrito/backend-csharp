using Banco.Classes;

Console.Clear();
Console.WriteLine($"Bem-vindo ao NuBankinho");
Console.WriteLine();

ContaCorrente contaEmilly = new ContaCorrente();
ContaCorrente contaYasmin = new ContaCorrente();

contaEmilly.Titular = "Emilly";
contaEmilly.Depositar(524f);

contaYasmin.Titular = "Yasmin";
contaYasmin.Depositar(1000f);

Console.WriteLine($"Conta da {contaEmilly.Titular} tem R${contaEmilly.Saldo}");
Console.WriteLine($"Conta da {contaYasmin.Titular} tem R${contaYasmin.Saldo}");

contaYasmin.Sacar(250f);

Console.WriteLine($"Voce sacou e a sua conta ficou com R${contaYasmin.Saldo}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"conta da {contaEmilly.Titular} tem R${contaEmilly.Saldo}");
Console.WriteLine($"conta da {contaYasmin.Titular} tem R${contaYasmin.Saldo}");
Console.WriteLine();