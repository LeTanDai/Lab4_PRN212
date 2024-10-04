using System;
using System.Collections.Generic;
using static System.Console;

public interface IAnimal
{
    void AboutMe();
}

public class Lion : IAnimal
{
    public void AboutMe() => WriteLine("This is Lion");
}

public class Tiger : IAnimal
{
    public void AboutMe() => WriteLine("This is Tiger");
}

public abstract class AnimalFactory
{
    public abstract IAnimal CreateAnimal();
}

public class LionFactory : AnimalFactory
{
    public override IAnimal CreateAnimal() => new Lion();
}

public class TigerFactory : AnimalFactory
{
    public override IAnimal CreateAnimal() => new Tiger();
}

class Demo1
{
    public void Run()
    {
        Console.WriteLine("*** Factory Method Pattern Demo.***\n");

        List<AnimalFactory> animalFactoryList = new List<AnimalFactory>
        {
            new TigerFactory(),
            new LionFactory()
        };

        foreach (var animalFactory in animalFactoryList)
        {
            animalFactory.CreateAnimal().AboutMe();
        }
        Console.WriteLine();
    }
}
