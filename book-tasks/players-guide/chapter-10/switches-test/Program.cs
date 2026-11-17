using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Choose your language: ");

string languageChoice = Console.ReadLine();

string language;
language = languageChoice switch
{
    "English" or "EN" => "Hello! ",
    "Chinese" or "简体中文" or "普通话" or "Chinese" or "CN" => "您好！",
    "Russian" or "Русский" or "RU" => "Привет! ",
    "Ukrainian" or "Українська" or "UA" => "Привіт! ",
    _ => "Sorry, this language is currently unavailablle. Available options: English, Chinese (Mandarin), Russian, Ukrainian"
};

Console.WriteLine(language);

// switch (language)
// {
//     case "English" or "EN": 
//         Console.WriteLine("Hello!");
//         break;
//     case "Chinese (Mandarin)" or "简体中文" or "普通话" or "Chinese" or "CN":
//         Console.WriteLine("您好！");
//         break;
//     case "Russian" or "RU":
//         Console.WriteLine("Привет!"); 
//         break;
//     case "Ukrainian" or "UA":
//         Console.WriteLine("Привіт!");
//         break;
//     default:
//         Console.WriteLine("Sorry, this language is currently unavailablle. Available options: English, Chinese (Mandarin), Russian, Ukrainian");
//         break;
// }

