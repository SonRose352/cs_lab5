Console.Write("Введите строку: ");
string str = Console.ReadLine();
string[] words = str.Split(' ');
string newstr = "";
foreach (string word in words)
{
    if (!newstr.Contains(word))
    {
        newstr += word + " ";
    }
}
Console.WriteLine(newstr);