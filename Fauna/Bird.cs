using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna;

public class Bird : Creature
{
    public Bird()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Bird was created!");
        Console.ResetColor();
        
    }
    internal Bird (string species)
    {
        Console.WriteLine($"The {species} is flying.");
    }
}