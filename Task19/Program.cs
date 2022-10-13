// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.Write("Введите пятизначный палиндром: ");
string palindrom = Console.ReadLine();

void Checkpalindrom(string palindrom)
{
  if (palindrom[0] == palindrom[4] || palindrom[1] == palindrom[3])
  {
    Console.WriteLine($"Ваше число: {palindrom} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {palindrom} - НЕ палиндром.");
}

if (palindrom.Length == 5)
{
  Checkpalindrom(palindrom);
}
else Console.WriteLine($"Введи правильное число");