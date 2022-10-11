static void start()
{
    Console.WriteLine("Are you 18+? (Y/N)");
    string question = Console.ReadLine();
    question = question.ToUpper();
    if (question == "Y")
    {
        Console.WriteLine("You are 18+.");
    }
    else if (question == "N")
    {
        Console.WriteLine("You are not 18+.");
    }
    else
    {
        Console.WriteLine("Invalid input.");
        start();
    }
}

start();
