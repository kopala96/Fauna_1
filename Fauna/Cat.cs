namespace Fauna;

public class Cat : Animal
{
    public Cat() : base("Kata")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Cat was created!");
        Console.ResetColor();
    }

    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}