
using PilaresPOO.classes.Aprendizagem;

namespace PilaresPOO.classes
{
    public class Aluno : Pessoa
    {
        public int idade { get; set; }
        public string? nome { get; set; }
        public int matricula { get; set; }
        public string? curso { get; set; }
        public float media { get; set; }
    }
}