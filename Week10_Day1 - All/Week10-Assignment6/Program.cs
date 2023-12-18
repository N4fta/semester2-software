static Boolean CheckForInteger(string inputString)
{
    try
    {
        Convert.ToInt32(inputString);
        return true;
    }
    catch
    {
        Console.WriteLine("\nThat is not a valid number");
        return false;
    }
}

int sizeOfArrays = 0;
string inputString = "";


while (true) {
    Console.Write("\nPlease input the amount of people to be added: ");
    inputString = Console.ReadLine();
    if (CheckForInteger(inputString)) { sizeOfArrays = Convert.ToInt32(inputString); break; }
}

string[] arrayNames = new string[sizeOfArrays];
int[] arrayAges = new int[sizeOfArrays];
Console.WriteLine("-------------------------------------------");
for (int i = 0; i < sizeOfArrays; i++) {
    Console.Write("\nPlease input the name for person "+(i+1)+": ");
    arrayNames[i] = Console.ReadLine();
    while (true) {
        Console.Write("\nPlease input the age for person "+(i+1)+": ");
        inputString = Console.ReadLine();
        if (CheckForInteger(inputString)) { arrayAges[i] = Convert.ToInt32(inputString); break; }
    }
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("\nYou have inputted the following data: ");
for (int i = 0; i < sizeOfArrays; i++) {
    Console.WriteLine(" " + arrayNames[i] + " (" + arrayAges[i] + " year(s) old) ");
}

Console.WriteLine("\nPress any key to exit");
Console.ReadLine();