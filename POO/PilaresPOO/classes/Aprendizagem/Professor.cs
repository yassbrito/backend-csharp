
namespace PilaresPOO.classes.Aprendizagem
{
    public class Professor: Pessoa
    {
        public int NIF { get; set; }
        public float salario { get; set; }

        public Professor(int _nif)
        {
            NIF = _nif;
        }
    }
}