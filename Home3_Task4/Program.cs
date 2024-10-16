int[] array = { 5, -3, 9, -1, 2, -7, 0 };
int[] positiveArray = array.Where(n => n >= 0).ToArray();

Console.WriteLine("[" + string.Join(", ", positiveArray) + "]");