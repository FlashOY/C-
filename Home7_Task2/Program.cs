// Задача 2: Функция Аккермана
// Описание: Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// ● Вход: m = 2, n = 3
// ● Выход: A(m, n) = 29
// ● Вход: m = 1, n = 4
// ● Выход: A(m, n) = 7.


public class Task2
{
    public static int Ackermann(int m, int n)
    {
        return m == 0 ? n + 1 : n == 0 ? Ackermann(m - 1, 1) : Ackermann(m - 1, Ackermann(m, n - 1));
    }

    public static void Main(string[] args)
    {
        int m = 2, n = 3;
        Console.WriteLine(Ackermann(m, n));
    }
}
