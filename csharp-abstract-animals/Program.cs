using csharp_abstract_animals;
using System;


public abstract class Animal
{
    public abstract void Sleep();

    public abstract void Towards();

    public abstract void Eat();


    static void Main(string[] args)
    {
      
        Sparrow sparrow = new Sparrow();
        sparrow.Eat();
        sparrow.Towards();
        sparrow.GetFly(sparrow);

        Eagle eagle = new Eagle();
        eagle.Eat();
        eagle.Towards();
        eagle.GetFly(eagle);


        Dolphin dolphin = new Dolphin();
        dolphin.Eat();
        dolphin.Towards();
        dolphin.GetSwimmers(dolphin);

        Dog dog = new Dog();
        dog.Eat();
        dog.Sleep();

        Puffin puffin = new Puffin();
        puffin.Eat();
        puffin.Sleep();
        puffin.Towards();
        puffin.GetFly(puffin);
        puffin.GetSwimmers(puffin);

    }

}

