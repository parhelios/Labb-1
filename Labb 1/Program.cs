using System.Numerics;
using System.Text.RegularExpressions;

Console.Write("Ange textsträng: ");
string userInput = Console.ReadLine();
string input = userInput.ToLower().Replace(" ", string.Empty).Trim();

char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
    'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
    'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Å', 'Ä', 'Ö', 'a',
    'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
    'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
    'x', 'y', 'z', 'å', 'ä', 'ö' };

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

static List<int> CharacterPosition (string input)
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