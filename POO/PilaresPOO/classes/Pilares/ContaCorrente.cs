
namespace PilaresPOO.classes.Pilares
{
    public class ContaCorrente : Conta
    {
        public float Limite { get; set; }

        public bool Transferir(float valor, Conta contaDestino)
        {
            return false;
        }
        public override bool Depositar(float valor)
        {
            if (valor >= 0)
            {

                Saldo = Saldo + valor;
                return true;

            } else {
                Console.WriteLine($"depositou na conta");
                return false;
            }
        }

        public override float Sacar(float valor)
        {
            if(valor >= Saldo)
            {
                Saldo = Saldo - valor;
                return valor;
            } else
            {
                Console.WriteLine($"Valor maior que o saldo");
                return 0;
            }
        }
    }
}