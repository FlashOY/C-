// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает
// сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17


Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999) //if (num > 99 && num < 1000)
{
    int firstdigit = num / 100; //456/10=4.56
    int seconddigit = num % 10; //456 = 450 + 6 = 6; 

    int result = firstdigit + seconddigit;

    Console.WriteLine($"Результат сложения первой и последней цифры числа =  + {result}");
}
else
{
    Console.WriteLine("Введённое число не является трёхзначным");
}

