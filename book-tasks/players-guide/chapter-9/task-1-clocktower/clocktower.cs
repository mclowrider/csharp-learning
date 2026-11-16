
int baseTime = 1;
string[] dayCycle = new string[2];
dayCycle[0] = "AM";
dayCycle[1] = "PM";

while(true){
    Thread.Sleep(400);
    int timeModified = baseTime++;
    int currentTime = Math.Clamp(timeModified, 1, 12);
    Console.WriteLine($"The time is: {currentTime}{dayCycle[0]}");
    Thread.Sleep(400);
    if (currentTime % 2 == 0)
    {
        Console.WriteLine("Tick.");
    }
    else
    {
        Console.WriteLine("Tock.");
    }
    if (currentTime == 12)
    {
        baseTime = 1;
        Array.Reverse(dayCycle);
    }
}
