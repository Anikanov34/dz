// See https://aka.ms/new-console-template for more information
// ДЗ 6
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("введите число");
float N = Convert.ToInt32(Console.ReadLine());

Console.Write($"{((N/2)%1)==0}");
