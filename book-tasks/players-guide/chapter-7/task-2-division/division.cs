
Console.WriteLine("How many eggs were gathered today? ");
if (int.TryParse(Console.ReadLine(), out int chocolateEggCount)){}
else{Console.WriteLine("Invalid input."); return;}

int leftoverEggs = chocolateEggCount % 4;
int eggsDividedEqually = (chocolateEggCount - leftoverEggs) / 4;

Console.WriteLine("Each sister gets " + eggsDividedEqually 
+ " eggs, and the duckbear gets " + leftoverEggs + " eggs.");