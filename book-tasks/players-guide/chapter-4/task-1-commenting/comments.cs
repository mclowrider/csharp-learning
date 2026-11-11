Console.WriteLine("What kind of item are we talking about?");
string a = Console.ReadLine(); // stores a noun from command line input
Console.WriteLine("How would you describe it? Big? Azure? Tattered? Something else?");
string b = Console.ReadLine(); // stores an adjective from command line input
string c = "Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!"); /* Combines the different string
variables into a single sentence using a simple arithmetic expression */ 
