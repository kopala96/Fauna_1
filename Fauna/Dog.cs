namespace Fauna;

public class Dog : Animal
{
	public Dog() : base("Dzagli")
    {
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Dog was created!");
		Console.ResetColor();
	}

	public Dog(string name) : base(name)
    {
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine($"Dog with name {name} was created!");
		Console.ResetColor();
	}

    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}
