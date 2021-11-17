// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = new int[8];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.WriteLine(array[i]);
}
Console.WriteLine(" ");
for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);