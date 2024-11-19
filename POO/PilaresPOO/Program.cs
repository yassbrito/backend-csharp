
using PilaresPOO.classes.Pilares;
Console.Clear();

ContaCorrente ctYas = new ContaCorrente();
ctYas.Titular = "Yasmin Brito";
// ctYas.botaSaldoai(1000000f) ;

Console.WriteLine($"Titular da conta: {ctYas.Titular}");
Console.WriteLine($"Saldo da conta: {ctYas.Saldo}");

float valorSacado = ctYas.Sacar(1200f);

Console.WriteLine($"Valor do saque: {valorSacado}");
Console.WriteLine($"Novo saldo: {ctYas.getSaldo()}");

