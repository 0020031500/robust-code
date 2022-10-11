using System.Net.NetworkInformation;

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

static bool validateNumber(int number)
{
    if (number < 1 || number > 100)
    {
        return false;
    }
    else
    {
        return true;
    }
}

static void start()
{
    Console.WriteLine("Please enter a number:");
    int number = getNumber();
    if (!validateNumber(number))
    {
        Console.WriteLine("That number is not between 1 and 100.");
        start();
    }
    else
    {
        Console.WriteLine("That number is between 1 and 100.");
    }
}

start();
