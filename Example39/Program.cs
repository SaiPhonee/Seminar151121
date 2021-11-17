// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.WriteLine(array[i]);
}
Console.WriteLine(" ");
for (int i = 0; i < array.Length / 2; i++)
{
    int n = array[i] * array[array.Length - i - 1];
    Console.WriteLine(n);
}