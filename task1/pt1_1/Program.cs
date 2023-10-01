using System.Text.RegularExpressions;

Regex regex = new Regex("^[a-zA-Z][a-zA-Z\\d]{1,9}$");

String line;
while ((line = Console.ReadLine()) != null && !line.Equals(""))
{
    line = line.Trim();
    Console.WriteLine(regex.IsMatch(line));
}