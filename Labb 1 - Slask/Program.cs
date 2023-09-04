string s = "This is a string";
var duplicates = new List<char>();
foreach (var item in s)
{
    if (s.IndexOf(item) != s.LastIndexOf(item) &&
        !duplicates.Contains(item))
    {
        duplicates.Add(item);
    }
}

Console.WriteLine(string.Join(",", duplicates));