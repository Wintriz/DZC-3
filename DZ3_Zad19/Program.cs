﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (читается слева направо и справа налево одинаково)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число которое является палиндромом");
string pal = Console.ReadLine();
if (pal[0] == pal[4] && pal[1] == pal[3])
{
    Console.Write("Палиндром: ");
    Console.Write(pal);
}
else
{
    Console.Write("Не палиндром: ");
    Console.Write(pal);
}