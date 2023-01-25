using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("skriv tre heltal");

        string[] tal = new string[3];
        tal[0] = Console.ReadLine();
        tal[1] = Console.ReadLine();

        tal[2] = Console.ReadLine();

        Console.WriteLine("Här är de tre Talen");
        Console.WriteLine($"{tal[0]}, {tal[1]} och {tal[2]}");
    }
}