namespace Fauna;

public class Creature
{
    public Creature()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Creature was created!");
        Console.ResetColor();
        Breath();
    }

    public string Name { get; set; }

    protected void Breath()
    {    
        Console.WriteLine("Creature is breathing");
    }
}
