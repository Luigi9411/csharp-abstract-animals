using csharp_abstract_animals;
using System;




//Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.

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

        Eagle eagle = new Eagle();
        eagle.Eat();
        eagle.Towards();

        Dolphin dolphin = new Dolphin();
        dolphin.Eat();
        dolphin.Towards();

        Dog dog = new Dog();
        dog.Eat();
        dog.Sleep();
    }
}

