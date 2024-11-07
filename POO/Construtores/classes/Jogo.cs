using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.classes
{
    public class Jogo
    {
        public string nome { get; set; }
        public int lancamento { get; set; }
        public string genero { get; set; }
        public float preco { get; set; }

        public Jogo(string no, int la, string ge, float pr){
            nome = no;
            lancamento = la;
            genero = ge;
            preco = pr;
        }

        public void ExibirDados()
        {
            Console.WriteLine($@"
            nome: {nome}
            lancamento: {lancamento}
            genero:{genero}
            preco: {preco}
            ");
        }
    }
}