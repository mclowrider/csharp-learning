Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.Title = "Square Root Machine";

Console.Write("I'm the square root machine! Press any key to begin");
Console.ReadKey(true);
Console.WriteLine("\nGreat! Type in a number to obtain its square root. \nWhen done, type \"exit\" to exit program.");

while(true){
    string exitPrompt = "exit"; 
    Console.Write("Number: ");
    string userPrompt = Console.ReadLine();
    Console.Clear();
    if (double.TryParse(userPrompt, out double inputNumber))
    {
        double outputNumber = Math.Sqrt(inputNumber);
        Console.WriteLine("The square root of " + inputNumber + " is " + outputNumber);
    }
    else if (userPrompt == exitPrompt)
    {
        Console.WriteLine("Have a good day, user!");
        return;
    }
    else{Console.WriteLine("Invalid input. Please enter a numeric value."); Console.Beep(400, 800);}
}

