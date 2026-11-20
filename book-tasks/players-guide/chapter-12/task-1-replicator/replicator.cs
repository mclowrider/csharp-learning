

int[] array1 = new int [5];
int[] array2 = new int [5];

Console.WriteLine("Enter five integers for your array: ");

for (int i = 0; i <= 4; i++) array1[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("COntents of array #1: " + string.Join(", ", array1));
Console.WriteLine("Contents of array #2: " + string.Join(", ", array2));

Console.WriteLine("Copy the contents of array #1 into array #2? Type [Y] for \"Yes\", [N] for \"No\" (Default: N)");

if ("Y" == Console.ReadLine())
{
    for (int i = 0; i <= 4; i++)
    {
        Console.WriteLine("\nCopying...");
        array2[i] = array1[i];
        Console.WriteLine("COntents of array #1: " + string.Join(", ", array1));
        Console.WriteLine("Contents of array #2: " + string.Join(", ", array2));
        Thread.Sleep(750);
    }
}
else
{
    Console.Clear();
    Console.WriteLine("Operation aborted. \n"); 
    Console.WriteLine("Contents of array #1: " + string.Join(", ", array1));
    Console.WriteLine("Contents of array #2: " + string.Join(", ", array2));
    return;
}

Console.Clear();
Console.WriteLine("Successfully copied array #1 into array #2: \n");
Console.WriteLine("Contents of array #1: " + string.Join(", ", array1));
Console.WriteLine("Contents of array #2: " + string.Join(", ", array2));