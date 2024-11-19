
namespace PilaresPOO.classes.Pilares
{
    public class ContaPoupanca : Conta
    {
        public float Limite { get; set; }
    
        public bool Transferir(float valor, Conta contaDestino)
        {
            return false;
        }
        public override bool Depositar(float valor)
        {
            throw new NotImplementedException();
        }

        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }
    }
}