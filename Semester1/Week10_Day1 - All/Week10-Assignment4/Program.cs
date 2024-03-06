
using System.Reflection.Metadata.Ecma335;

List<string> dialogueOptions = new List<string>();
dialogueOptions.Add("...");
dialogueOptions.Add("If you dont input an integer I'm just going to keep asking");
dialogueOptions.Add("I have all the time in the world");
dialogueOptions.Add("Still waiting");
dialogueOptions.Add("Now you're just trying to provoke me");
dialogueOptions.Add("-_-");
dialogueOptions.Add("zero"); // paramater for dialogue choice

static Boolean CheckForInteger(string inputString, List<string> dialogueOptions)
{
    try
    {
        Convert.ToInt32(inputString);
        return true;
    }
    catch
    {
        if (dialogueOptions[6] == "zero") {
            Console.WriteLine("\n" + dialogueOptions[1]);
            dialogueOptions[6] = "one";
        }
        else if (dialogueOptions[6] == "two") {
            Console.WriteLine("\nAGAIN?! Ugh");
            dialogueOptions[6] = "one";
        }
        else {
            Random rnd = new Random();
            int x = rnd.Next(0, 6);
            Console.WriteLine("\n" + dialogueOptions[x]);
        }
        return false;
    }
}


Console.Write("\nPlease supply an integer: ");
string inputString = Console.ReadLine();
while (true)
{
    if (CheckForInteger(inputString, dialogueOptions)) { break; }
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
    Console.Write("\nPlease supply an integer: ");
    inputString = Console.ReadLine();
}
if (dialogueOptions[6]=="one") { Console.WriteLine("\nWas that so hard?\n"); dialogueOptions[6] = "two"; }
int baseNumber = Convert.ToInt32(inputString);


Console.Write("\nHow many multiplications should I calculate? ");
inputString = Console.ReadLine();
while (true)
{
    if (CheckForInteger(inputString, dialogueOptions)) { break; }
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
    Console.Write("\nPlease supply an integer: ");
    inputString = Console.ReadLine();
}
int multiplicationNumber = Convert.ToInt32(inputString);

Console.WriteLine("\nHere you go:");
for (int i = 0; i < multiplicationNumber; i=i) {
    i++;
    Console.WriteLine(i+" x "+baseNumber+" = "+baseNumber*i);
}

Console.WriteLine("\nPress any key to exit");
Console.ReadLine();