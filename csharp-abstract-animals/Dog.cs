using csharp_abstract_animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dog : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Il cane sta dormendo Zzz");
        }

        public override void Towards()
        {
            Console.WriteLine("Il verso del cane è: bau ");
        }

        public override void Eat()
        {
            Console.WriteLine("Il cane mangia tutto");
        }
    }
}

