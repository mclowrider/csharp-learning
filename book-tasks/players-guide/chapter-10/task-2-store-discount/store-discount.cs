
Console.WriteLine("Welcome to the store. What's your name, user? ");
string username = Console.ReadLine();

string[] items = new string [7];
items[0] = "Kettle"; items[1] = "Sausage"; items[2] = "Torch";
items[3] = "Climbing Gear"; items[4] = "Machete"; items[5] = "Gun";
items[6] = "Canoe";
int[] orderNumbers = {1, 2, 3, 4, 5, 6, 7};
int[] priceList = {15, 8, 10, 25, 20, 30, 35};
int playerWallet = Math.Clamp(100, 0, 10000);
string storeExitPrompt;

if (username == "Ted" || username == "TED" || username == "ted")
{
    Console.WriteLine("Oh! I remember you!");
    priceList[0] /= 2; priceList[1] /= 2; priceList[2] /= 2; priceList[3] /= 2; priceList[4] /= 2; priceList[5] /= 2; priceList[6] /= 2;
}

Console.WriteLine($"Greetings, {username}. Here's the list of available items: ");

bool storeLoop(){
    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine(orderNumbers[i] + " – " + items[i]);
    }
    Console.WriteLine($"-Which item are you interested in? *Current balance: [{playerWallet}] Gold*");
    string playerChoice = Console.ReadLine();
    Console.WriteLine($"-How much for this one? [{playerChoice}]");
    string prices = playerChoice switch
    {
        "1" or "Kettle" => $"-The {items[0]} is {priceList[0]} Gold",
        "2" or "Sausage" => $"-The {items[1]} is {priceList[1]} Gold",
        "3" or "Torch" => $"-The {items[2]} is {priceList[2]} Gold",
        "4" or "Climbing Gear" => $"-The {items[3]} is {priceList[3]} Gold",
        "5" or "Machete" => $"-The {items[4]} is {priceList[4]} Gold",
        "6" or "Gun" => $"-The {items[5]} is {priceList[5]} Gold",
        "7" or "Canoe" => $"-The {items[6]} is {priceList[6]} Gold",
        // "Exit" or "exit" or "EXIT" => "exit",
        _ => "Please input a valid number/item name."
    };
    int payment = playerChoice switch
    {
        "1" or "Kettle" => priceList[0],
        "2" or "Sausage" => priceList[1],
        "3" or "Torch" => priceList[2],
        "4" or "Climbing Gear" => priceList[3],
        "5" or "Machete" => priceList[4],
        "6" or "Gun" => priceList[5],
        "7" or "Canoe" => priceList[6],
        _ => 0
    };

    Console.WriteLine(prices);
    // if (prices == "exit")
    // {
    //     return false;
    // }
    if (prices != "Please input a valid number/item name.")
    {
        Console.WriteLine($"Do you wish to purchase [{playerChoice}]? Y/N (Default: No)");
        string yesNoAnswer = Console.ReadLine();
        bool yesAnswer = yesNoAnswer == "Y" || yesNoAnswer == "y" || yesNoAnswer == "Yes" || yesNoAnswer == "yes" || yesNoAnswer == "YES";
        bool enoughMoney = playerWallet - payment > 0;
        if (yesAnswer == true && enoughMoney){
            playerWallet = Math.Clamp(playerWallet - payment, 0, 10000);
            Console.WriteLine($"Thanks for purchasing [{playerChoice}]! Current balance: [{playerWallet}] Gold. Do you wish to exit the store? Y/N (Default: No)");
            storeExitPrompt = Console.ReadLine();
            if (storeExitPrompt == "Y" || storeExitPrompt == "y" || storeExitPrompt == "Yes" || storeExitPrompt == "yes" || storeExitPrompt == "YES")
            {
                return false;
            }
            else if (storeExitPrompt == "N" || storeExitPrompt == "n" || storeExitPrompt == "No" || storeExitPrompt == "no" || storeExitPrompt == "NO")
            {
                return true;
            }
            else{return true;}
        }
        else if (!enoughMoney){Console.WriteLine($"You don't have enough money to purchase [{playerChoice}]."); return true;}
        else{return true;}
    }
    else{return true;}
}

while(storeLoop() == true){
    storeLoop();
}

Console.WriteLine($"You exit the store. You have [{playerWallet}] Gold left.");
