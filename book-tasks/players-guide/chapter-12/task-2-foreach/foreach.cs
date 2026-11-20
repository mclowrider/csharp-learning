// Rewritten examples utilizing foreach instead of for

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
foreach (int index in array)
{
if (index < currentSmallest)
currentSmallest = index;
}
Console.WriteLine("Smallest element: " + currentSmallest);
int total = 0;
foreach (int index in array) total += index;
float average = (float)total / array.Length;
Console.WriteLine("Total average: " + average);