using System.Security.Cryptography.X509Certificates;

namespace Fauna;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("Vefxvi");
        Console.WriteLine();
        Dog dog = new Dog("Bullet");
        Console.WriteLine();
        Cat cat = new Cat();
        Bird bird = new Bird();

    }
    
}