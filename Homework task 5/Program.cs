/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int[] array = new int[8];

void FillArray(ref int[] Array, int smallest, int biggest)
{
    Console.WriteLine();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(smallest, biggest);
        Console.Write($"{Array[i]} ");
    }
}

FillArray(ref array, 100, 1000);

int QtyPositiveElements = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) QtyPositiveElements += 1;
}

Console.WriteLine($"\nВ этом массиве {QtyPositiveElements} чётных чисел");



/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.
[3, 7, 23, 12] -> 19*/
int[] masiv = new int[8];
FillArray(ref masiv, 0, 100);

int sum = 0;
for (int x = 1; x < masiv.Length; x += 2)
{
    sum += masiv[x];
}
Console.WriteLine($"\nСумма элементов на нечётных позициях равна {sum}");


/*[-4, -6, 89, 6] -> 0
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов 
массива.
[3 7 22 2 78] -> 76*/
int[] intArray = new int[8];
FillArray(ref intArray, 0, 100);

int min = intArray[0];
int max = intArray[0];
for (int k = 1; k < intArray.Length; k++)
{
    if (intArray[k] > max) max = intArray[k];
    if (intArray[k] < min) min = intArray[k];
}
Console.Write($"\nРазница между минимальным - {min} и максимальным - {max} элементами массива равна {max - min}");
