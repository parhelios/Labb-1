using System;
using System.Reflection.Metadata.Ecma335;

Console.Write("Ange textsträng: ");
string userInput = Console.ReadLine();
string input = userInput.Replace(" ", string.Empty).Trim();

bool[] isDigit = new bool[input.Length];
string[] digits = new string[input.Length];
char[] chars = input.ToCharArray();

for (int i = 0; i < input.Length; i++)
{
    isDigit[i] = Char.IsDigit(input[i]);    
}

for (int i = 0; i < chars.Length; i++)
{
    digits[i] = Convert.ToString(chars[i]);
}

while (true)
{
    string[] substrings = new string[input.Length];
    int counter = 0;

    for (int o = 0; o < substrings.Length; o++)
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
                    if (substrings[counter] == null)
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
                    if (substrings[counter] == null)
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
                    if (substrings[counter] == null)
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
                    if (substrings[counter] == null)
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
                    if (substrings[counter] == null)
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
                    if (substrings[counter] == null)
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
                    if (substrings[counter] == null)
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
                    if (substrings[counter] == null)
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
                    if (substrings[counter] == null)
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
                    if (substrings[counter] == null)
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
        Console.WriteLine("Resultat: ");
        for (int i = 0; i < substrings.Length; i++)
        {
            Console.WriteLine(substrings[i]);
        }
        Console.ReadKey();
    }    
}
