
string n;
Console.WriteLine("Input an integer");
n = Console.ReadLine();
if (int.TryParse(n, out int nParsed)){}
else{Console.WriteLine("Not an integer."); return;}
int remainder = nParsed % 2;

if (remainder == 0)
{
    Console.WriteLine("\nYour number is even.");
}
else
{
    Console.WriteLine("\nYour number is odd.");
}

