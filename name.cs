static void start()
{
    Console.WriteLine("What is your name?");
    string fullName = "";
    string name = Console.ReadLine();
    string[] arrayOfNames = name.Split(" ");
    for (int i = 0; i < arrayOfNames.Length; i++)
    {
        string namePart = arrayOfNames[i];
        fullName = fullName + char.ToUpper(namePart[0]) + namePart.Substring(1) + " ";
    }


    Console.WriteLine("Hi, " + fullName.Substring(0, fullName.Length-1) + "!");
}

start();
