// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите число от 10 до 99:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10 || number > 99)
{
    Console.WriteLine("Число должно быть в диапазоне от 10 до 99.");
}
else
{
    int digit1 = number / 10;    // Первая цифра числа
    int digit2 = number % 10;    // Вторая цифра числа
    int maxDigit = (digit1 > digit2) ? digit1 : digit2;

    Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");
}