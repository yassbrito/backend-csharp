using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.classes
{
    public class Aluno
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public int matricula { get; set; }

        public Aluno(string no, int id, int ma){
            nome = no;
            idade = id;
            matricula = ma;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$"
            nome: {nome}
            idade: {idade}
            matricula: {matricula}
            ");
        }
    }
}