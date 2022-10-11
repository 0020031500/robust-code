static void start()
{
    Console.WriteLine("What is your favourite food?");
    string question = Console.ReadLine();
    if (question.Length > 5)
    {
        Console.WriteLine("You entered a string with more than 5 characters!");
        start();
    }
    else
    {
        Console.WriteLine("Wow, I love " + question + " too!");
    }
}

start();
