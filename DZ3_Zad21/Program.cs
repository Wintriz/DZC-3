// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координату А");
double AX = double.Parse(Console.ReadLine()!);
double AY = double.Parse(Console.ReadLine()!);
double AZ = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату В");
double BX = double.Parse(Console.ReadLine()!);
double BY = double.Parse(Console.ReadLine()!);
double BZ = double.Parse(Console.ReadLine()!);
double AB = Math.Sqrt((BX-AX) * (BX-AX) + (BY-AY) * (BY-AY) + (BZ-AZ) * (BZ-AZ));
Console.Write("Расстояние между точками А и В = ");
Console.WriteLine(AB);


