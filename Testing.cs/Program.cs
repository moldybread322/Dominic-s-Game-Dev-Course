// bool isDirty = false;

//if (isDirty)
//{
   // Console.WriteLine("Lets clean it");
//}
//else
//{Console.WriteLine("its clean");
//}    

// string chickensEaten = 0;

// while (chickensEaten < 10)
// {
//     Console.WriteLine("You're not full yet");
//     chickensEaten++;

//     if (chickensEaten == 10)
//     {
//        Console.WriteLine("You're full");
//     }
// }

// public int chickenFoot = 20;

// private int chickenFootfood = 30;

// List<string> humans = List<string>();

// humans.Add("John");

// Console.WriteLine(humans);

// int coin = 0;

// string startingTitle = "Welcome player, select your character"

// string coinCollect = "you have obtained a coin";

// int Add(int a, int b)
// {
//     return a + b;
// }

// List<string> Characters = new List<string>();

// Characters.Add("Bill")
// Characters.Add("Joshep")
// Characters.Add("cory")
// Characters.Add("sammy")

// if (coin < 100);
// {
//     Console.WriteLine(startingTitle);
// }
//     else
//     {
//         Console.WriteLine("you are at max coins, please try again")
//     }
//         while


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("This is the coin collection game based on choices you make within the game. This is a simple program that will be used as an assignment");
        Console.WriteLine("You are teleported to an open field with many bushes that may contain coins or dangerous entities");
        Console.WriteLine("Let's get started!");

        string[] options = { "Bush In front", "Bush Behind", "Bush at right side" };

        while (true)
        {
            DisplayOptions(options);

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int choice) && choice >= 1 && choice <= options.Length)
            {
                ProcessChoice(choice, options);
            }
            else
            {
                Console.WriteLine("Choose a number that the thing tells you to, we're not trying to break things right now");
            }
        }
    }

    static void DisplayOptions(string[] options)
    {
        Console.WriteLine("\nOptions:");
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}");
        }
    }

    static void ProcessChoice(int choice, string[] options)
    {
        Console.WriteLine($"You chose: {options[choice - 1]}");

        // Implement logic based on the chosen option
        switch (choice)
        {
            case 1:
                Console.WriteLine("You check the bush in front and find a shiny coin!");
                break;
            case 2:
                Console.WriteLine("You inspect the bush behind you but find nothing.");
                break;
            case 3:
                Console.WriteLine("Thanks for playing! Goodbye.");
                Environment.Exit(0);
                break;
        }
    }
}
