Console.WriteLine("Ange textsträng: ");
string userInput = Console.ReadLine().Trim();
Console.WriteLine();

string preSequence = string.Empty;
string postSequence = string.Empty;
double counter = 0;

for (int i = 0; i < userInput.Length; i++)
{
    if (!Char.IsDigit(userInput[i]))
    {
        continue;
    }
    else if (Char.IsDigit(userInput[i]))
    {
        string substring = "";
        substring += userInput[i];

        for (int j = i + 1; j < userInput.Length; j++)
        {
            if (!Char.IsDigit(userInput[j]))
            {
                break;
            }

            substring += userInput[j];

            if (userInput[i] == userInput[j])
            {
                if (substring.Length < 3)
                {
                    //Console.WriteLine("Sekvens för kort."); //debug
                    break;
                }
                //Console.WriteLine("Matchning hittad."); //debug

                double substringVal = double.Parse(substring);
                counter += substringVal;
                //i start, j slut, anv Substring istället för Split

                preSequence = userInput.Substring(0, i);
                postSequence = userInput.Substring (j, (userInput.Length - preSequence.Length - substring.Length));

                Console.Write(preSequence);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(substring);
                Console.ResetColor();
                Console.Write(postSequence);
                Console.WriteLine();

                break;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Totalsumma: " + counter);
Console.ReadKey();