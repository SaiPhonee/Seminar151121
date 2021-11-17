// 35. Определить, присутствует ли в заданном массиве, некоторое число 

int[] array = new int[10];
int index = 0;
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
    if (array[i] == number)
    {
        index = 1;
    }
}
Console.WriteLine(" ");
if (index > 0)
{
    Console.WriteLine("Число присутствует в массиве");
}
else
{
    Console.WriteLine("Число отсутствует");
}