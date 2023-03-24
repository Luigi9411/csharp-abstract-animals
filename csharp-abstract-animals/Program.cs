using csharp_abstract_animals;
using System;

var sparrow = new Sparrow();
var eagle = new Eagle();
var  dolphin = new Dolphin();
var dog = new Dog();
var puffin = new Puffin();

sparrow.Eat();
sparrow.Towards();
sparrow.GetFly(sparrow);
Console.WriteLine();
eagle.Eat();
eagle.Towards();
eagle.GetFly(eagle);
Console.WriteLine();
dolphin.Eat();
dolphin.Towards();
dolphin.GetSwimmers(dolphin);
Console.WriteLine();
dog.Eat();
dog.Sleep();
Console.WriteLine();
puffin.Eat();
puffin.Sleep();
puffin.Towards();
puffin.GetFly(puffin);
puffin.GetSwimmers(puffin);
Console.ReadLine();


public abstract class Animal
{
    public abstract void Sleep();

    public abstract void Towards();

    public abstract void Eat();


}

