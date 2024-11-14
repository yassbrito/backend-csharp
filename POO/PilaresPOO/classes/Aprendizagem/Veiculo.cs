
namespace PilaresPOO.classes.Aprendizagem
{
    public abstract class Veiculo
    {
        public string? marca { get; set; }
        public string? modelo { get; set; }
        public string? cor { get; set; }
        public float potencia { get; set; }
        public int qtdPassageiro { get; set; }


        public void Ligar()
        {
            Console.WriteLine($"o carro ligou!");
        }

        public void Desligar()
        {
            Console.WriteLine($"o carro desligou!");
        }

        public void Buzinar()
        {
            Console.WriteLine($"o carro buzinou! Bibiiiii!");
        }
    }
}