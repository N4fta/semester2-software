
using System.Linq.Expressions;

List<int> userInputtedNumbers = new List<int>();
string inputString = "";
Boolean validInput = true;
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
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        return false;
    }
}



while (true)
{
    Console.Write("\nPlease input an integer (or $ to exit): ");
    inputString = Console.ReadLine();
    if (inputString == "$") { 
        break; 
    }
    validInput = CheckForInteger(inputString);
    if (validInput) { 
        userInputtedNumbers.Add(Convert.ToInt32(inputString));
    }
}


Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("\nResults:");
int averageValue = (int)userInputtedNumbers.Average();
int highestNumber = userInputtedNumbers.Max();
int lowestNumber = userInputtedNumbers.Min();
int sumOfAllNumbers = userInputtedNumbers.Sum();
int multiplicationOfAllNumbers = 1;
foreach (int item in userInputtedNumbers) { multiplicationOfAllNumbers *= item; }
Console.WriteLine(" The average (rounded down) is " + averageValue +
    "\n The highest number is " + highestNumber +
    "\n The lowest number is " + lowestNumber +
    "\n The sum of all numbers is " + sumOfAllNumbers +
    "\n The multiplication of all numbers is " + multiplicationOfAllNumbers);

Console.WriteLine("\nPress any key to exit");
Console.ReadLine();