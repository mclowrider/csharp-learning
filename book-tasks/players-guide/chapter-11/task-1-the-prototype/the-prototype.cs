/* • Build a program that will allow a user, the pilot, to enter a number.
• If the number is above 100 or less than 0, keep asking.
• Clear the screen once the program has collected a good number.
• Ask a second user, the hunter, to guess numbers.
• Indicate whether the user guessed too high, too low, or guessed right.
• Loop until they get it right, then end the program. */

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
string userInput1; // first user's input
string userInput2; // second user's input
int user1Number;
int user2Number;

while (true) {

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("User #1, enter a number from 0 to 100: ");
    userInput1 = Console.ReadLine();

    if (int.TryParse(userInput1, out int userInput1Integer)){

        if(userInput1Integer <= 100 && userInput1Integer >= 0)
        {
            user1Number = userInput1Integer;
            Console.Clear();
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\"{userInput1}\" is not a valid number. Please only enter valid integers from 0 to 100."); 
            Console.Beep(100, 500);
            continue;
        }

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\"{userInput1}\" is not a valid number. Please only enter valid integers from 0 to 100.");
        Console.Beep(100, 500); 
        continue;
    }
}

while (true) {

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("User #2, guess the number: ");
    userInput2 = Console.ReadLine();

    if (int.TryParse(userInput2, out int userInput2Integer)){

        if(userInput2Integer <= 100 && userInput2Integer >= 0)
        {
            user2Number = userInput2Integer;
            if (user2Number == user1Number)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You've guessed correctly!");
                Console.Beep(700, 800);
                break;
            }
            else if (user2Number < user1Number)
            {
                Console.WriteLine($"{user2Number} is too low. ");
                continue;
            }
            else if (user2Number > user1Number)
            {
                Console.WriteLine($"{user2Number} is too high. ");
                continue;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\"{userInput2}\" is not a valid number. Please only enter valid integers from 0 to 100.");
            Console.Beep(100, 500); 
            continue;
        }

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\"{userInput2}\" is not a valid number. Please only enter valid integers from 0 to 100."); 
        Console.Beep(100, 500);
        continue;
    }
}
