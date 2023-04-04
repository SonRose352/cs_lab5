Console.Write("Введите строку: ");
string str = Console.ReadLine();
string[] words = str.Split(' ');
foreach(string word in words)
{
    if (word.Length == 4)
        str = str.Replace(word, "love_Is");
}
Console.WriteLine($"Строка после замен: {str}");