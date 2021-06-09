using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings Planet!");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Greetings {name}. What is your quest?");
            var quest = Console.ReadLine();
            Console.WriteLine($"Your quest is {quest}.");
            Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
            var swallow = Console.ReadLine();
            Console.WriteLine($"Yes, {swallow} is correct!");
        }
    }
}
