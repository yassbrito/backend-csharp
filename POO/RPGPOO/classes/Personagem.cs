
namespace RPGPOO.classes
{
    public class Personagem
    {

        public String? Nome;

        public int? Idade;

        public string? Armadura;


        public string? IA;


        public void Atacar()
        {
            Console.WriteLine($"O(a)  {Nome} atacou :0");
        }

        public void Defender()
        {
            Console.WriteLine($"O(a) {Nome} defendeu :)");
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O(a) {Nome} restaurou sua armadura :0");
        }





    }
}
