﻿Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
int secondDigit = num / 10 % 10;
int lastDigit = num % 10;

int result = secondDigit;
int count = 1;

while (count < lastDigit)
{
result = result * secondDigit; // result *= secondDigit
count++;
}

Console.WriteLine(result);
}
else
{
Console.WriteLine("Ошибка ввода!");
}