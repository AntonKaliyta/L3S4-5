// Программа задает массив из 12 случайных элементов, заполненный случайными числами из промежутка [-9,9], 
// и затем находит сумму положительных и сумму отрицательных элементов
// int[] array = new int[12];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);
// }
// System.Console.WriteLine($"[{String.Join(", ", array)}]");
// int Asum = 0; //Сумма положительных
// int Bsum = 0;  //Сумма отрицательных
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j]>0)
//     {
//         Asum+=array[j];
//     }
//     else
//     {
//         Bsum+=array[j];
//     }
// }
// System.Console.WriteLine();
// System.Console.WriteLine($"Сумма положительных элементов равна {Asum}, сумма отрицательных элементов равна {Bsum}");




// int[] CreateArray()
// {
// Console.WriteLine("Введите количество элементов массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
// Console.WriteLine($"Введите {i+1} элемент массива");
// array[i] = Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }






// int[] CreateRandomArray(int N, int start, int end)
// {
// int[] RandomArray = new int[N];
// for (int i = 0; i < N; i++)
// {
// RandomArray[i] = new Random().Next(start, end + 1);
// }
// return RandomArray;
// }


// меняет элементы массива - отрицательные на соответствующие положительнные и наоборот
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// int[] Array = CreateRandomArray(10, -100, 100);
// System.Console.WriteLine($"[{String.Join(", ", Array)}]");
// System.Console.WriteLine("преобразовывается в ");
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i]*=-1;
// }
// System.Console.WriteLine($"[{String.Join(", ", Array)}]");

// Программа проверяет присутвует ли заданное число в массиве
// System.Console.WriteLine("Введите длинну массива. Длинна равна ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int [size];
// for (int i = 0; i < size; i++)
// {
//     Array[i] = new Random().Next(-10,11);
// }
// System.Console.WriteLine($"[{String.Join(", ", Array)}]");
// System.Console.WriteLine();
// int x = new Random().Next(-10,11);
// System.Console.WriteLine(x);
// int z = 0;
// while (z<size)
// {
//     if (Array[z]==x)
//     {
//         System.Console.WriteLine();
//         System.Console.WriteLine("Да, есть");
//         break;
//     }
//     else if (z==size-1)
//     {
//         System.Console.WriteLine();
//         System.Console.WriteLine("Нет, нету");
//         break;
//     }
//     else
//     {
//         z++;

//     }
// }


// Задайте одномерный массив из 123 случайных чисел и найдите количество элементов значения которых лежат в отрезке [10,99]
// int size = 123;
// int[] Array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     Array[i] = new Random().Next(0,201);
// }
// System.Console.WriteLine($"[{String.Join(", ", Array)}]");
// int sum = 0;
// for (int i = 0; i < size; i++)
// {
//     if (Array[i]>9&&Array[i]<100) sum++;
    
// }
// System.Console.WriteLine();
// System.Console.WriteLine($"Количество элементов равно {sum} ");




// Программа находит произведение пар чисел в одномерном массиве. Пара - первое и последнее, второе и предпоследнее и так далее, при нечетном массиве среднее число перемножать не нужно

// int size = new Random().Next(7,9);
// int[] Array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     Array[i] = new Random().Next(1,11);
// }
// System.Console.WriteLine($"[{String.Join(", ", Array)}]");
// System.Console.WriteLine();
// int j = 0;
// int f = size-1;
// while (j<(size+1)/2)
// {
//     if (j==(size)/2)
//     {
//          System.Console.Write($"{Array[j]} ");
//         break;
//     }
//     else
//     {
//         int x = Array[j]*Array[f];
//         System.Console.Write($"{x} ");
//         j++;
//         f=f-1;     
//     }
// }

