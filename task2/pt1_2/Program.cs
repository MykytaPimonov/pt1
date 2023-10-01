using System.Text.RegularExpressions;

String Filter(String line, String oldPart, String newPart)
{
    Regex regex = new Regex(oldPart, RegexOptions.IgnoreCase);
    return regex.Replace(line, newPart);
}

String o = "firstname", n = "lastname";

String input;
while ((input = Console.ReadLine()) != null)
{
    if (input.Equals("")) break;

    String res = Filter(input, o, n);
    Console.WriteLine(input + "  ->  " + res);
}