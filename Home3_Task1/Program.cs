int[] array = { 1, 3, 8, 19, 3, 8 };
int num = 8;
bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        isExistNum = true;
        break;
    }
}

Console.WriteLine(isExistNum ? "Да" : "Нет");