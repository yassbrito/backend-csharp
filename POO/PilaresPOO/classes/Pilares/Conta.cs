
namespace PilaresPOO.classes.Pilares
{
    public abstract class Conta
    {
        public float Saldo { get; set; }
        public string? Titular { get; set; }

        public abstract float Sacar(float valor);
        public abstract bool Depositar(float valor);

        // public void botaSaldoai(float grana)
        // {
        //     Saldo = grana;
        // }

        // public float devolveSaldoai(float grana)
        // {
        //     return Saldo;
        // }

        public float getSaldo()
        {
            return Saldo;
        }
    }
}