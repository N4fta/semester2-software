
List<string> dialogueOptions = new List<string>();
dialogueOptions.Add("If you dont input a whole number I'm just going to keep asking");
dialogueOptions.Add("I have all the time in the world");
dialogueOptions.Add("Still waiting");
dialogueOptions.Add("Now you're just trying to provoke me");
dialogueOptions.Add("-_-");

Boolean firstCatch = true;
Console.Write("\nPlease supply a whole number: ");
string inputtedString = Console.ReadLine();

while (true){
    try {
        Convert.ToInt32(inputtedString);
        break;
    }
    catch{

        Random rnd = new Random();
        if (firstCatch)
        {
            Console.WriteLine("\n" + dialogueOptions[0]);
            firstCatch = false;
        }
        else
        {
            int x = rnd.Next(0, 5);
            Console.WriteLine("\n" + dialogueOptions[x]);
        }
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        Console.Write("\nPlease supply a whole number: ");
        inputtedString = Console.ReadLine();
    } 
}
int inputNumber = Convert.ToInt32(inputtedString);

if (!firstCatch) { Console.WriteLine("Was that so hard?\n"); }

if (inputNumber % 2 == 0) {
Console.WriteLine(inputNumber+" is pair!\n");
}
else{ 
Console.WriteLine(inputNumber+" is not pair!\n");
}

Console.WriteLine("\nPress any key to exit");
Console.ReadLine();