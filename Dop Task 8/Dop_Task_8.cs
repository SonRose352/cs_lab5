﻿Console.WriteLine("Введите текст: ");
string str = Console.ReadLine();
str = str.Replace("ноль", "0");
str = str.Replace("один", "1");
str = str.Replace("два", "2");
str = str.Replace("три", "3");
str = str.Replace("четыре", "4");
str = str.Replace("пять", "5");
str = str.Replace("шесть", "6");
str = str.Replace("семь", "7");
str = str.Replace("восемь", "8");
str = str.Replace("девять", "9");
Console.WriteLine($"Строка после изменений: {str}");