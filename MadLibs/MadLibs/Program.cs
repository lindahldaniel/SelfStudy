using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity, verb;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.Write("Enter a verb: ");
            verb = Console.ReadLine();

            Console.WriteLine("\nRoses are " + color);
            Console.WriteLine(pluralNoun +" are blue");
            Console.WriteLine("I love " + celebrity);
            Console.WriteLine("This fucker like to " + verb + ", \njust as much as you.");

            Console.ReadLine();
        }
    }
}
