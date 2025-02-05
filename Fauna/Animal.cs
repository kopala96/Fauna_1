﻿namespace Fauna;

public class Animal : Creature
{
	//public Animal()
	//{
	//	Console.ForegroundColor = ConsoleColor.Green;
	//	Console.WriteLine("Animal was created!");
	//	Console.ResetColor();
	//}

	public Animal(string name)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Animal with name {name} was created!");
		Console.ResetColor();
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
