//   Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Введите натуральное число.");
}
else
{
    Console.Write("Цифры числа: ");
    while (number > 0)
    {
        int digit = number % 10;
        Console.Write(digit);
        number /= 10;
        if (number > 0)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}