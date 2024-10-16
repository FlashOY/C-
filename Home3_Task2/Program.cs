int[] array = { 1, -5, 6, -7, 3 };

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
}

Console.WriteLine("[" + string.Join(", ", array) + "]");