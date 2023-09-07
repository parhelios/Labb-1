Console.Write("Ange textsträng: ");
string userInput = Console.ReadLine();
string input = userInput.ToLower().Replace(" ", string.Empty).Trim();

//string onlyDigts = new String(userInput.Where(Char.IsDigit).ToArray());

//Console.WriteLine(onlyDigts);

Console.WriteLine("----------------------------");


char[] inputChar = input.ToCharArray();
char[] outputChar = new char[inputChar.Length];

//List<int> outputList = CharacterPosition(input);

string[] subStrings = input.Split(alphabet);

foreach (string subString in subStrings)
{
    Console.WriteLine(subString);
}

//foreach (int index in outputList)
//{
//    Console.WriteLine(index);
//}

//Console.WriteLine("----------------------------");

//foreach (char character in inputChar)
//{
//    Console.WriteLine(character);

//}

//string[] subStringSection = new string[inputChar.Length];
//for (int i = 0; i < subStringSection.Length; i++)
//{
//    subStringSection[i] = subStringSection[i].Substring(0, outputList[8]);
//    Console.WriteLine(subStringSection[i]);
//}





//List<char> letterPos = new List<char>();
//List<char> numList = new List<char>();

//for (int i = 0; i < inputChar.Length; i++)
//{
//    if (inputChar == alphabet)
//    {
//        letterPos.Add(alphabet[i]);
//    }
//}

//foreach (char letter in letterPos)
//{
//    Console.WriteLine(letter);
//}

//for (int i = 0; i < inputChar.Length; i++)
//{
//    bool letterCheck = Char.IsDigit(inputChar[i]);
//    if (letterCheck)
//    {
//        Console.WriteLine(letterCheck);

//    }
//    else
//    {
//        Console.WriteLine(letterCheck);
//    }
//}

static List<int> CharacterPosition(string input)
{
    List<int> charIndex = new List<int>();

    for (int i = 0; i < input.Length; i++)
    {
        if (char.IsLetter(input[i]))
        {
            charIndex.Add(i);
        }
    }
    return charIndex;
}

char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
    'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
    'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Å', 'Ä', 'Ö', 'a',
    'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
    'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
    'x', 'y', 'z', 'å', 'ä', 'ö' };

string[] subStrings = input.Split(alphabet);
double[] numSubStrings = new double[subStrings.Length];

for (int i = 0; i < subStrings.Length; i++)
{
    numSubStrings[i] = double.Parse(subStrings[i]);
}



//for (int i = 0; i < subStrings.Length; i++)
//{
//        if (subStrings[i] == "1")
//    {
//        Console.WriteLine(subStrings[i] + "1");
//    }
//    else if (subStrings[i] == "2")
//    { 
//        Console.WriteLine(subStrings[i] + "2");
//    }
//}

______________________________________________________________


    bool[] isDigit = new bool[input.Length];
string[] digits = new string[input.Length];
char[] chars = input.ToCharArray();
string[] substrings = new string[input.Length];

for (int i = 0; i < input.Length; i++)
{
    isDigit[i] = Char.IsDigit(input[i]);
}

for (int i = 0; i < chars.Length; i++)
{
    digits[i] = Convert.ToString(chars[i]);
}

//ghettolösning
for (int i = 0; i < substrings.Length; i++)
{
    substrings[i] = string.Empty;
}

int counter = -1;
//int runCounter = isDigit.Length;
//runCounter++;
while (true)
{
    counter++;
    for (int i = 0; i < isDigit.Length; i++)
    {
        if (isDigit[i] == false)
        {
            continue;
        }
        else if (isDigit[i] == true)
        {
            if (digits[i] == "0")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("0"))
                    {
                        if (substrings[counter].StartsWith("0"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("0"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("0"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
            else if (digits[i] == "1")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("1"))
                    {
                        if (substrings[counter].StartsWith("1"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("1"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("1"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
            else if (digits[i] == "2")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("2"))
                    {
                        if (substrings[counter].StartsWith("2"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("2"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("2"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
            else if (digits[i] == "3")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("3"))
                    {
                        if (substrings[counter].StartsWith("3"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("3"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("3"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
            else if (digits[i] == "4")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("4"))
                    {
                        if (substrings[counter].StartsWith("4"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("4"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("4"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
            else if (digits[i] == "5")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("5"))
                    {
                        if (substrings[counter].StartsWith("5"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("5"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("5"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
            else if (digits[i] == "6")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("6"))
                    {
                        if (substrings[counter].StartsWith("6"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("6"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("6"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
            else if (digits[i] == "7")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("7"))
                    {
                        if (substrings[counter].StartsWith("7"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("7"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("7"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
            else if (digits[i] == "8")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("8"))
                    {
                        if (substrings[counter].StartsWith("8"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("8"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("8"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
            else if (digits[i] == "9")
            {
                if (substrings[counter] == String.Empty)
                {
                    substrings[counter] += digits[i];
                    continue;
                }
                else
                {
                    if (substrings[counter].Contains("9"))
                    {
                        if (substrings[counter].StartsWith("9"))
                        {
                            substrings[counter] += digits[i];
                            break;
                        }
                        else if (!substrings[counter].StartsWith("9"))
                        {
                            substrings[counter] += digits[i];
                        }
                    }
                    else if (!substrings[counter].Contains("9"))
                    {
                        substrings[counter] += digits[i];
                    }
                }
            }
        }
    }

    if (substrings[counter].Length < 3)
    {
        counter--;
    }
    else
    {
        continue;
    }

    //TODO: någonting som "hoppar över" den senaste startsiffran i arrayen

    //break;
}
Console.WriteLine("Resultat: ");
for (int i = 0; i < substrings.Length; i++)
{
    Console.WriteLine(substrings[i]);
}


//någonting för att bryta loopen om den kört lika många gånger som det finns sekvenser
//samt något för att ignorera sekvenser som är kortare än 3 siffror
//Console.ReadKey();
//if (isDigit.Length) 
//{
//    break;
//}
//else
//{
//    continue;
//}
