using System;

namespace bot
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.Title = "Your AI friend";
           Console.ForegroundColor = ConsoleColor.DarkCyan;
           Console.WindowHeight = 20;
           Console.WindowWidth = 80;

            Console.WriteLine("What's your name?");

            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName + ", nice to meet you!");

            Console.WriteLine("How are you to day " + userName + ".");

            string input = Console.ReadLine();

if (input.ToLower() == "good"){
Console.WriteLine("That's good");
}
if (input.ToLower() == "bad")
{
Console.WriteLine("what's wrong");
Console.ReadLine();
Console.WriteLine("that dose not sound good");
}

    Console.WriteLine("do you want to hear a joke");

    string input2 = Console.ReadLine();

if (input2.ToLower() == "yes"){
Console.WriteLine("the world is not flat but its a square");
}
if (input2.ToLower() == "no")
{
Console.WriteLine("to bad im still going to tell you the earth is not flat but its a square");

Console.ReadLine();

}
            Console.ReadKey();
        }
    }
}
