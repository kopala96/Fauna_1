﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna;

public class Fish : Creature
{
    public Fish() 
    {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine("Fish was created!");
         Console.ResetColor();

    }
    public void Swim ()
    {
        Console.WriteLine("The fish is Swiming.");
    }
}