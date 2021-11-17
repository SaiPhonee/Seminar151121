// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int[] array = new int[10];
int max = 0;
int min = 100;
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine(" ");
Console.WriteLine(max);
Console.WriteLine(min);
result = max - min;
Console.WriteLine(result);