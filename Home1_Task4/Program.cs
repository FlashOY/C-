﻿// Задание 4
// Вывести нечетные числа
// Описание: Напишите метод, который на вход принимает число (number), а на выходе
// выводит все нечетные числа от 1 до number (включительно), после каждого числа
// должен быть знак пробела.
// Пример использования: На входе:
// ● number: 5
// На выходе:
// ● 1 3 5
// На входе:
// ● number: 8
// На выходе:
// ● 1 3 5 7

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i += 2)
{
Console.Write(i + " ");
}
 
