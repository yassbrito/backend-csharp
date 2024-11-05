using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeClasses.Classes
{
    public class Veiculo
    {
        public string marca;
        public string modelo;
        public string cor;
        public string potencia;
        public int qtdPortas;

        public void Acelerar()
        {
            Console.WriteLine($"O {modelo} está acelerando: Vrum vrum!");
        }
        public void Ligar()
        {
            Console.WriteLine($"Ligando o {modelo} ");

        }
        public void Desligar()
        {
            Console.WriteLine($"{modelo} desligado");
        }
        public void Freiar()
        {
            Console.WriteLine($"{modelo}  Freiando: ");
        }

    }
}
