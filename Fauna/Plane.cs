using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna;

public class Plane : Vehicle
{
    public Plane()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Plane was created!");
        Console.ResetColor();
    }
}