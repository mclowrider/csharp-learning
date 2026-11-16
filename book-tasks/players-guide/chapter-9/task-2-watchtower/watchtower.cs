
// ask user for x and y value
// using the provided image, display a message about the enemy's position according to the coordinates (x and y)

Console.BackgroundColor = ConsoleColor.Black;

Console.WriteLine("Please input enemy coordinates when prompted using integers. Press any key to continue. Type \"exit\" in order to exit program. ");
Console.ReadKey(true);

while (true){

    Console.Write("Please enter the x coordinate: ");
    string x = Console.ReadLine();
    Console.Write("Please enter the y coordinate: ");
    string y = Console.ReadLine();

    bool inputXParsed = int.TryParse(x, out int parsedX);
    bool inputYParsed = int.TryParse(y, out int parsedY);
    bool inputsParsed = inputXParsed && inputYParsed;

    if (inputsParsed)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        if (parsedX < 0 && parsedY < 0)
        {
            Console.WriteLine("The enemy is to the southwest!");
        }
        else if (parsedX < 0 && parsedY == 0)
        {
            Console.WriteLine("The enemy is to the west!");
        }
        else if (parsedX < 0 && parsedY > 0)
        {
            Console.WriteLine("The enemy is to the northwest!");
        }
        else if (parsedX == 0 && parsedY < 0)
        {
            Console.WriteLine("The enemy is to the south!");
        }
        else if (parsedX == 0 && parsedY == 0)
        {
            Console.WriteLine("The enemy is UPON US!!");
        }
        else if (parsedX == 0 && parsedY > 0)
        {
            Console.WriteLine("The enemy is to the north!");
        }
        else if (parsedX > 0 && parsedY < 0)
        {
            Console.WriteLine("The enemy is to the southeast!");
        }
        else if (parsedX > 0 && parsedY == 0)
        {
            Console.WriteLine("The enemy is to the east!");
        }
        else if (parsedX > 0 && parsedY > 0)
        {
            Console.WriteLine("The enemy is to the northeast!");
        }
        else {Console.WriteLine("Error. Try again.");}
    }
    else if (x == "exit" || y == "exit"){break;}
    else {Console.WriteLine("Please enter only integers. ");}
}

Console.WriteLine("Thanks for playing. ");