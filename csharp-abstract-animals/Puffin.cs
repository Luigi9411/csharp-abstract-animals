using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Puffin : Animal, TheSwimmers, TheFly
    {
        public override void Sleep()
        {
            Console.WriteLine("Il puffin sta dormendo Zzz");
        }

        public override void Towards()
        {
            Console.WriteLine("Il verso del puffin è: gluglu ");
        }

        public override void Eat()
        {
            Console.WriteLine("Il puffin mangia phantom");
        }

        public void Swim()
        {
            Console.WriteLine("Sto nuotando!!!");
        }

        public void GetSwimmers()
        {
            Swim();
        }

        public void Fly()
        {
            Console.WriteLine("Sto volando!!!");
        }

        public void GetFly()
        {
            Fly();
        }
    }
}
