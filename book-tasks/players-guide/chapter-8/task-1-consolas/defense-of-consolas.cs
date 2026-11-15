/* 8x8 grid;    Ask the user for target Row and target Column;
Compute the rows and columns on which to deploy the squad (points on four adjacent grid tiles; *note: diagonal != adjacent)
Display target Row & Column in red; Deployment Points in green.
Play Console.Beep() when the results are displayed.
*/
Console.Title = "Defense of Consolas";
Console.BackgroundColor = ConsoleColor.Black;

Console.Write("Welcome to Defense of Consolas. Press any key to continue. Type \"exit\" to exit program.");
while (true){

    string exitStatement = "exit";
    string userRow;
    string userColumn;
    string[] squadMembers = new string [4]; // An array for the squad members

    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("\nWhat's the target column? ");
    userColumn = Console.ReadLine();
    Console.WriteLine("What's the target row? ");
    userRow = Console.ReadLine();
        if (userRow == "exit" || userColumn == exitStatement){
            Console.WriteLine("Thanks for playing!");
            return;
        }
        else if (int.TryParse(userRow, out int userReturnRow) && int.TryParse(userColumn, out int userReturnColumn)) // Parses the input for integer
        {
            bool inputInRange;
            if (inputInRange = Math.Clamp(userReturnRow, 1, 8) == userReturnRow){ // Checks if the input value is in field range
                Console.WriteLine($"The target is on tile ({userReturnRow}, {userReturnColumn})");
                int posRow = Math.Clamp(userReturnRow, 2, 7);
                int posColumn = Math.Clamp(userReturnColumn, 2, 7);
                squadMembers[0] = Convert.ToString(posColumn+1) + ", " + posRow;
                squadMembers[1] = posColumn + ", " + Convert.ToString(posRow-1);
                squadMembers[2] = Convert.ToString(posColumn-1) + ", " + posRow;
                squadMembers[3] = posColumn + ", " + Convert.ToString(posRow+1);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The positions are: \nPos1: {squadMembers[0]} \nPos2: {squadMembers[1]} \nPos3: {squadMembers[2]} \nPos4: {squadMembers[3]}");
                Console.Beep(400, 500);
                Console.WriteLine("\nPoint secured!");
            }
            else{Console.WriteLine("Please only use numbers 1 through 8");}
        }
        else{Console.WriteLine("Please only enter integers.");}
}
