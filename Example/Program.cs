// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

// int[] array = new int[12];
// int SummaOtr = 0;
// int SummaPol = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     //Console.Write(array[i] + " ");
//     if (array[i] < 0)
//     {
//         SummaOtr = SummaOtr + array[i];
//     }
//     else
//     {
//         SummaPol = SummaPol + array[i];
//     }
// }
// Console.WriteLine(SummaOtr);
// Console.WriteLine(SummaPol);
// 34. Написать программу замену элементов массива на противоположные

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 20);
//     array[i] = -array[i];
//     Console.Write(array[i] + " ");
// }
// 35. Определить, присутствует ли в заданном массиве, некоторое число 

// int[] array = new int[10];
// int index = 0;
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 10);
//     Console.Write(array[i] + " ");
//     if (array[i] == number)
//     {
//         index = 1;
//     }
// }
// Console.WriteLine(" ");
// if (index > 0)
// {
//     Console.WriteLine("Число присутствует в массиве");
// }
// else
// {
//     Console.WriteLine("Число отсутствует");
// }
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// int[] array = new int[30];
// int evennumber = 0;
// int oddnumber = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     if (array[i] % 2 == 0)
//     {
//         evennumber++;
//     }
//     else
//     {
//         oddnumber++;
//     }
// }
// Console.WriteLine($"Количество четных чисел {evennumber}");
// Console.WriteLine($"Количество нечетных чисел {oddnumber}");
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] array = new int[123];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 1000);
//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// int[] array = new int[8];
// int sum = 0; 
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 10);
//     Console.WriteLine(array[i]);
// }
// Console.WriteLine(" ");
// for (int i = 1; i < array.Length; i = i + 2)
// {
//     sum = sum + array[i];
// }
// Console.WriteLine(sum);

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 10);
//     Console.WriteLine(array[i]);
// }
// Console.WriteLine(" ");
// for (int i = 0; i < array.Length/2; i++)
// {
//     int n = array[i] * array[array.Length - i - 1];
//     Console.WriteLine(n);
// }

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// int[] array = new int[10];
// int max = 0;
// int min = 100;
// int result = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 100);
//     Console.Write(array[i] + " ");
// }
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
// }
// Console.WriteLine(" ");
// Console.WriteLine(max);
// Console.WriteLine(min);
// result = max - min;
// Console.WriteLine(result);













//bool FindNumber(int[] array, int number)
// int[] FindNumber(int number)
// {
//     int[] array = new int[10];
//     int index = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//         Console.Write(array[i] + " ");
//         if (array[i] == number)
//         {
//             index = 1;
//         }
//     }
//     Console.WriteLine(" ");
//     if (index > 0)
//     {
//         Console.WriteLine("Число присутствует в массиве");
//     }
//     else
//     {
//         Console.WriteLine("Число отсутствует");
//     }
//     return array;
// }
// FindNumber(5);
// // 

// int[] array = new int[10];
// int[] FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 100);
//     }
//     return arr;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

//FillArray(array);
//PrintArray(array);

