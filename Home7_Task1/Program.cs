// Задача 1: Вывод натуральных чисел в промежутке от M до N
// Описание: Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8


public class Task1
{
    public static void PrintRange(int M, int N)
    {
        if (M > N) return;
        Console.Write(M + (M < N ? ", " : ""));
        PrintRange(M + 1, N);
    }

    public static void Main(string[] args)
    {
        int M = 1, N = 5;
        PrintRange(M, N);
    }
}
