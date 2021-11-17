// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[30];
int evennumber = 0;
int oddnumber = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        evennumber++;
    }
    else
    {
        oddnumber++;
    }
}
Console.WriteLine($"Количество четных чисел {evennumber}");
Console.WriteLine($"Количество нечетных чисел {oddnumber}");