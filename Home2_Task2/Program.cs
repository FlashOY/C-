// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координату X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Координаты не должны быть равны нулю.");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти.");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти.");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти.");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти.");
}