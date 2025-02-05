using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Alien : Creature
    {
        public Alien()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Alien was created!");
            Console.ResetColor();
        }
    }
}