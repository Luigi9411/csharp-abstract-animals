using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Dolphin : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Il delfino sta dormendo Zzz");
        }

        public override void Towards()
        {
            Console.WriteLine("Il verso del delfino curioso è: dammi la Big Frut ");
        }

        public override void Eat()
        {
            Console.WriteLine("Il delfino mangia Big Fruit");
        }
    }
}
