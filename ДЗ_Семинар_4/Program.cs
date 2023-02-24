// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Например 3, 5 -> 243 (3⁵) или 2, 4 -> 16
// System.Console.WriteLine("Введите число А ");
// int A = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число B ");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = A;
// for (int i = 1; i < B; i++)
// {
//     result = result * A;
// }
// System.Console.WriteLine(result);


// double Result(int A,int B)
// {
//     double result = Math.Pow(A,B);
//     return result;
// }
// System.Console.WriteLine("Введите число А ");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число B ");
// int numB = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Результат равен {Result(numA,numB)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Например 452 -> 11 или 82 -> 10 или 9012 -> 12
// System.Console.WriteLine("Введите число ");
// string x = Convert.ToString(Console.ReadLine());
// int number = Int32.Parse(x);
// int result = 0;
// for (int i = 0; i <= x.Length; i++)
// {
//     int rest = number%10;
//     number/=10;
//     result+=rest;
// }
// System.Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,101);
    }
    System.Console.WriteLine($"[{String.Join(", ", array)}]");
    System.Console.WriteLine();
}
GetArray(4);
GetArray(8);
GetArray(16);

