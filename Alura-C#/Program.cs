﻿string wellcomeMessage = ("Wellcome to my C# program");

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
        case 3: PreviewAband();
            break;
        case 4: ShowBandsAverage();
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

    foreach(string banda in registredBands.Keys)
    {
        Console.WriteLine($"\nregistered bands: {banda}");
    }


    Console.Write("\nPress any key to return to the Menu...");
    Console.ReadKey();
    Console.Clear();
    ShowLogo();
    ShowMenuOptions();
}

void PreviewAband()
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
        Console.Write($"\r\nWhat rating would you like to give to {bandName}?: ");
        int nota = int.Parse(Console.ReadLine()!);

        registredBands[bandName].Add(nota);
        Console.WriteLine($"The rating: {nota}, was succesfully given to: {bandName}");
        Thread.Sleep(2500);
        Console.Write("\nPress any key to return to the Menu...");
        Console.ReadKey();
        Console.Clear();
        ShowLogo();
        ShowMenuOptions();
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

void ShowBandsAverage()
{
    Console.Clear();
    Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ █▀▀ 　 █▀▀█ █▀▀█ ▀▀█▀▀ ░▀░ █▀▀▄ █▀▀▀ 
▒█▀▀▄ █▄▄█ █░░█ █░░█ ▀▀█ 　 █▄▄▀ █▄▄█ ░░█░░ ▀█▀ █░░█ █░▀█ 
▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ ▀▀▀ 　 ▀░▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀▀▀▀");
    Console.Write("Witch band would you like to know the avarage?: ");
    string bandName = Console.ReadLine()!;

    if (registredBands.ContainsKey(bandName))
    {
        List<int> bandRating = registredBands[bandName];
        Thread.Sleep(2000);
        Console.WriteLine($"The rating for {bandName} is: {bandRating.Average()}!");
        Thread.Sleep(1000);
        Console.Write("\nPress any key to return to the Menu...");
        Console.ReadKey();
        Console.Clear();
        ShowLogo();
        ShowMenuOptions();
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

