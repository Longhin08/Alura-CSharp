string wellcomeMessage = ("Wellcome to my C# program");

//List<string> bandList = new List<string> {"Red Hot Chilli Peppers", "Foo Fighters", "Oasis", "KISS!", "AC/DC", "valvlavla" };

Dictionary<string, List<int>> registredBands = new Dictionary<string, List<int>>();
registredBands.Add("Red Hot Chilli Peppers", new List<int> { 10, 10, 8 });
registredBands.Add("Foo Fighters", new List<int> { 10, 9, 8 });
registredBands.Add("Oasis", new List<int> { 8, 0, 5 });
registredBands.Add("KISS!", new List<int> { 10, 7, 4 });


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
        case 3: RreviewAband;
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

    {
        Console.WriteLine($"\nregistered bands: {banda}");
    }


    Console.Write("\nPress any key to return to the Menu...");
    Console.ReadKey();
    Console.Clear();
    ShowLogo();
    ShowMenuOptions();
}

void RreviewAband()
{   
    Console.Clear();
    Console.WriteLine(@"
    ▒█▀▀█ █▀▀█ ▀▀█▀▀ █▀▀ 　 █▀▀█ 　 ▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ 
    ▒█▄▄▀ █▄▄█ ░░█░░ █▀▀ 　 █▄▄█ 　 ▒█▀▀▄ █▄▄█ █░░█ █░░█ 
    ▒█░▒█ ▀░░▀ ░░▀░░ ▀▀▀ 　 ▀░░▀ 　 ▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░");

    Console.Write("Which band do you want to review?: ");
    string bandName = Console.ReadLine()!;

    if (registredBands.ContainsKey(bandName))
    {
        Console.Write($"\r\nWhat rating would you like to give to: {bandName}?");
        int nota = int.Parse(Console.ReadLine()!);

        registredBands[bandName].Add(nota);
    }
    else
    {
        Console.WriteLine($"\nThe band: {bandName} does not exist :´(");
        Console.Write("\nPress any key to return to the Menu...");
        Console.ReadKey();
        Console.Clear();
        ShowLogo();
        ShowMenuOptions();

    }




}

ShowLogo();
ShowMenuOptions();

