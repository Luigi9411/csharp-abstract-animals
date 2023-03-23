using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Eagle : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("L' aquila sta dormendo Zzz");
        }

        public override void Towards()
        {
            Console.WriteLine("Il verso dell'aquila è: Lotito liberami ");
        }

        public override void Eat()
        {
            Console.WriteLine("L' acquila mangia carne");
        }
    }
}
