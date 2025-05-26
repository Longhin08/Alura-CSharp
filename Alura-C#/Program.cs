string wellcomeMessage = ("Wellcome to my C# program");

List<string> bandList = new List<string> {"Red Hot Chilli Peppers", "Foo Fighters", "Oasis", "KISS!", "AC/DC", "valvlavla" };

void ShowLogo()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(wellcomeMessage);
}

void ShowMenuOptions()
{
    Console.WriteLine("\nType 1 to register a new band");
    Console.WriteLine("Type 2 to show all bands");
    Console.WriteLine("Type 3 to rate a band");
    Console.WriteLine("Type 4 to show the band's average ");
    Console.WriteLine("Type -1 to Exit");

    Console.Write("\nType your wanted option: ");
    string optionChosenRaw = Console.ReadLine()!;
    int optionChosen = int.Parse(optionChosenRaw);


    switch (optionChosen)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            ShowBandList();
            break;
        case 3:
            Console.WriteLine("You chose option: " + optionChosen);
            break;
        case 4:
            Console.WriteLine("You chose option: " + optionChosen);
            break;
        case -1:
            Console.WriteLine("You chose option: " + optionChosen);
            Console.WriteLine("Thanks for using Screen Sound! ;)");
            break;
        default:
            Console.WriteLine("invalid option");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ 　 █▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ ▀▀█▀▀ ░▀░ █▀▀█ █▀▀▄ 
▒█▀▀▄ █▄▄█ █░░█ █░░█ 　 █▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▄▄▀ █▄▄█ ░░█░░ ▀█▀ █░░█ █░░█ 
▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ 　 ▀░▀▀ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀▀▀▀ ▀░░▀");
    Console.Write("\nEnter the band name: ");
    string bandName = Console.ReadLine()!;
    bandList.Add(bandName);
    Console.WriteLine($"The band {bandName} was successfully registered");
    Thread.Sleep(2100);
    Console.Clear();
    ShowLogo();
    ShowMenuOptions();
}

void ShowBandList()
{
    Console.Clear();
    Console.WriteLine(@"
    █▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀ █▀▀█ █▀▀ █▀▀▄ 　 █▀▀▄ █▀▀█ █▀▀▄ █▀▀▄ █▀▀ 
    █▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▀▀ █▄▄▀ █▀▀ █░░█ 　 █▀▀▄ █▄▄█ █░░█ █░░█ ▀▀█ 
    ▀░▀▀ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀░ 　 ▀▀▀░ ▀░░▀ ▀░░▀ ▀▀▀░ ▀▀▀");

    //for (int i = 0; i < bandList.Count; i++)
    //{
    //    Console.WriteLine($"\nregistered bands: {bandList[i]}");
    //}

    foreach (string banda in bandList)
    {
        Console.WriteLine($"\nregistered bands: {banda}");
    }


    Console.Write("\nPress any key to return to the Menu...");
    Console.ReadKey();
    Console.Clear();
    ShowLogo();
    ShowMenuOptions();
}



ShowLogo();
ShowMenuOptions();

