// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int SummaOtr = 0;
int SummaPol = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    //Console.Write(array[i] + " ");
    if (array[i] < 0)
    {
        SummaOtr = SummaOtr + array[i];
    }
    else
    {
        SummaPol = SummaPol + array[i];
    }
}
Console.WriteLine(SummaOtr);
Console.WriteLine(SummaPol);