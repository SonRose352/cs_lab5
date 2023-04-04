Console.Write("Введите строку: ");
string str = Console.ReadLine();
string[] names = str.Split(' ');
int index = Array.IndexOf(names, "Маша");
if (index != -1)
{
    Array.Resize(ref names, index);
}
Array.Sort(names);
foreach(string name in names)
{
    Console.WriteLine(name);
}