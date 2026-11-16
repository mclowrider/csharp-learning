

Console.WriteLine("Press any key to test your luck. Press \"Esc.\" in order to exit program.");

while (Console.ReadKey(true).Key != ConsoleKey.Escape){
    int randomNumber = Random.Shared.Next(6);
    if (randomNumber == 5){Console.WriteLine("Bullseye!");}
    else{Console.WriteLine("No luck, mate.");}
}

Console.WriteLine("Thanks for playing!");