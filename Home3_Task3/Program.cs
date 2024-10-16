int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}

double average = (double)sum / array.Length;
Console.WriteLine(average);
