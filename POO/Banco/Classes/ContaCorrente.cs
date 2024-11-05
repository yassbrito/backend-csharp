namespace Banco.Classes
{
    public class ContaCorrente
    {
        public int Numeroconta;
        public string? Titular;
        public float Saldo;

        public void Depositar(float valor)
        {
            Saldo = Saldo - valor;
        }
        public void Sacar(float valor)
        {
            Saldo = Saldo - valor;
        }
    }
}