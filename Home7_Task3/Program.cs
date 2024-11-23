// Задача 3: Вывод элементов массива в обратном порядке
// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: {1, 2, 3, 4, 5}
// ● Выход: 5, 4, 3, 2, 1
// ● Вход: {10, 20, 30, 40}
// ● Выход: 40, 30, 20, 10



public class Task3
{
    public static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0) return;
        Console.Write(array[index] + (index > 0 ? ", " : ""));
        PrintArrayReverse(array, index - 1);
    }

    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayReverse(array, array.Length - 1);
    }
}
