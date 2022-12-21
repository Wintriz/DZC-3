// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine()!);
int index = 0;
int newNum = 0;
Console.WriteLine("Сube table:");
while (index < num)
{
    index = index +1;
    newNum = index * index * index;
    Console.WriteLine(newNum);
}

