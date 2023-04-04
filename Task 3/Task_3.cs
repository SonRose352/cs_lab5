Console.Write("Введите строку: ");
string str = Console.ReadLine();
Console.Write("Введите, после скольки символов будет стоять знак: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = "";
for (int i = 0; i < str.Length; i++)
{
    result += str[i];
    if (i % 5 == 4)
        result += "\u263a";
}
Console.WriteLine($"Строка после изменения: {result}");