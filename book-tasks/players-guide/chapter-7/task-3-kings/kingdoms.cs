// Melik, Casik, Balik
// estate -- 1 point;   duchy -- 3 points;   province -- 6 points
// Program function: input current holdings, return score

int[] melikHoldings = new int[3];
int[] casikHoldings = new int[3];
int[] balikHoldings = new int[3];

int KingdomScore(int es, int du, int pr){
    int totalScore = es + (du*3) + (pr*6);
    return totalScore;
} // Method for getting the total score of a user

Console.WriteLine("How many estates does Melik own?");
melikHoldings[0] = int.Parse(Console.ReadLine());
Console.WriteLine("How many duchies does Melik own?");
melikHoldings[1] = int.Parse(Console.ReadLine());
Console.WriteLine("And how many provinces does Melik own?");
melikHoldings[2] = int.Parse(Console.ReadLine());
int melikScore = KingdomScore(melikHoldings[0], melikHoldings[1], melikHoldings[2]);
Console.WriteLine("Melik's total score: " + melikScore);

Console.WriteLine("How many estates does Casik own?");
casikHoldings[0] = int.Parse(Console.ReadLine());
Console.WriteLine("How many duchies does Casik own?");
casikHoldings[1] = int.Parse(Console.ReadLine());
Console.WriteLine("And how many provinces does Casik own?");
casikHoldings[2] = int.Parse(Console.ReadLine());
int casikScore = KingdomScore(casikHoldings[0], casikHoldings[1], casikHoldings[2]);
Console.WriteLine("Melik's total score: " + casikScore);

Console.WriteLine("How many estates does Balik own?");
balikHoldings[0] = int.Parse(Console.ReadLine());
Console.WriteLine("How many duchies does Balik own?");
balikHoldings[1] = int.Parse(Console.ReadLine());
Console.WriteLine("And how many provinces does Balik own?");
balikHoldings[2] = int.Parse(Console.ReadLine());
int balikScore = KingdomScore(balikHoldings[0], balikHoldings[1], balikHoldings[2]);
Console.WriteLine("Melik's total score: " + balikScore);

int[] scoreboard = {melikScore, casikScore, balikScore};
// My knowledge of C# is still limited in many aspects.

Console.WriteLine("So, the scores are as follows: \n Melik: " + scoreboard[0] + "\n Casik: " + scoreboard[1] + "\n Balik: " + scoreboard[2]);
