static int getNumber()
{
    int toReturn;
    try
    {
        toReturn = int.Parse(Console.ReadLine());
    }
    catch (FormatException e) {
        Console.WriteLine("That was not a number.");
        toReturn = getNumber();
    }
    return toReturn;
}


static void start()
{
    Console.WriteLine("Please enter a number:");
    getNumber();
}

start();
