Console.WriteLine("Ange textsträng: ");
string userInput = Console.ReadLine();
Console.WriteLine();

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

                string[] split = userInput.Split(substring);

                Console.Write(split[0]);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(substring);
                Console.ResetColor();
                Console.Write(split[1]);
                Console.WriteLine();

                break;
            }

        }
    }
}
Console.WriteLine();
Console.WriteLine("Totalsumma: " + counter);
Console.ReadKey();
