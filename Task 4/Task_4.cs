Console.Write("Введите строку: ");
string str = Console.ReadLine();
string[] words = str.Split(new char[]{' ', ',', '.', '!', '?', ':', ';', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
string max_word = words[0];
string min_word = words[0];
foreach (string word in words)
{
    if (word.Length < min_word.Length)
        min_word = word;
    if (word.Length > max_word.Length)
        max_word = word;
}
string result = "";
 for (int i = 0; i < max_word.Length; i++)
{
    result += max_word + ", ";
}
 for (int i = 0; i < min_word.Length; i++)
{
    result += min_word + ", ";
}
result = result.Remove(result.Length - 2, 2);
Console.Write($"Новая строка: {result}");