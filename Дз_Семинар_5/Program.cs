//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Например [345, 897, 568, 234] -> 2



// int size = new Random().Next(6,11);
// int[] Array = new int [size];
// for (int i = 0; i < size; i++)
// {
//     Array[i] = new Random().Next(100,1000);
// }
// System.Console.WriteLine($"[{String.Join(", ", Array)}]");
// System.Console.WriteLine();

// int x = 0;
// for (int j = 0; j < size; j++)
// {
//     if(Array[j]%2==0) x++;
// }
// System.Console.WriteLine($"Количество четных элементов в массиве равно {x}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Например [3, 7, 23, 12] -> 19 или [-4, -6, 89, 6] -> 0

// int size = new Random().Next(4,7);
// int[] Array = new int [size];
// for (int i = 0; i < size; i++)
// {
//     Array[i] = new Random().Next(0,11);
// }
// System.Console.WriteLine($"[{String.Join(", ", Array)}]");
// System.Console.WriteLine();

// int count = 0;
// for (int j = 0; j < size; j=j+2)
// {
//     count+=Array[j];
// }
// System.Console.WriteLine(count);




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например [3 7 22 2 78] -> 76

int size = 20;
int[] Array = new int[size];
for (int i = 0; i < size; i++)
{
    Array[i] = new Random().Next(0, 101);
}
System.Console.WriteLine($"[{String.Join(", ", Array)}]");
System.Console.WriteLine();

int max = 0;
for (int j = 0; j < size; j++)
{
    if (Array[j]>max) max = Array[j];
}
System.Console.WriteLine($"Максимальное число: {max}");
System.Console.WriteLine();

int min = 101;
for (int f = 0; f < size; f++)
{
    if (Array[f]<min) min = Array[f];
}
System.Console.WriteLine($"Минимальное число: {min}");
System.Console.WriteLine();

int result = max - min;
System.Console.WriteLine($"Разница равна {result}");