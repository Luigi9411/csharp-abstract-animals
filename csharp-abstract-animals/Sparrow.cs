using csharp_abstract_animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Sparrow : Animal, TheFly
    {
        public override void Sleep()
        {
            Console.WriteLine("Il passerotto sta dormendo Zzz");
        }

        public override void Towards()
        {
            Console.WriteLine("Il verso del passerotto è: mi è semblato di vedele un gatto ");
        }

        public override void Eat()
        {
            Console.WriteLine("Il passerotto mangia semi");
        }

        public void Fly()
        {
            Console.WriteLine("Sto volando!!!");
        }

        public void GetFly(TheFly animal)
        {
            animal.Fly();
        }
    }
}
