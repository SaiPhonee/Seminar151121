// 34. Написать программу замену элементов массива на противоположные

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 20);
    array[i] = -array[i];
    Console.Write(array[i] + " ");
}