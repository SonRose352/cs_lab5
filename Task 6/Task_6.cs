using System.Text;

Console.WriteLine("Введите строку (чтобы завершить ввод введите пустую строку): ");
StringBuilder result = new StringBuilder();
while (true)
{
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        break;
    }
    input += ".";
    string[] words = input.Split(' ');
    int index = 0;
    foreach (string word in words)
    {
        if (!string.IsNullOrEmpty(word))
        {
            if (index == 0)
            {
                result.Append(word);
            }
            else if (index == 1)
            {
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);
                result.Append(new string(letters));
            }
            index++;
            if (index >= words.Length)
            {
                index = 0;
            }
            if (index != 0 && index != words.Length - 1)
            {
                result.Append(" ");
            }
        }
    }
}
Console.WriteLine(result.ToString());