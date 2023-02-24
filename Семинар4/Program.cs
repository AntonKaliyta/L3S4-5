// выдает сууму все чисел от 1 до А

// System.Console.WriteLine("Введите число А");
// int A = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i = 1; i <= A; i++)
// {
//     sum = sum + i;
// }
// System.Console.WriteLine($"Сумма всеx чисел от 1 до {A} равна {sum}");


// То же, но через функцию

// int F_sum(int a)
// {
//     int sum = 0;
//     for (int i = 1; i<=a; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// System.Console.WriteLine("Введите число А");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всеx чисел от 1 до {x} равна {F_sum(x)}");

// Написать программу которая выдает количество цифр в числе - решено через длину строки

// System.Console.WriteLine("Введите число ");
// string x = Console.ReadLine();
// System.Console.WriteLine($"Количество цифр равно {x.Length}");

// либо

// Console.WriteLine("Введите число: ");
// string x = Convert.ToString(Console.ReadLine());
// int i = Convert.ToInt32(x.Length);
// Console.WriteLine($"В числе {x} ровно {i} цифр");

// Написать программу которая выдает количество цифр в числе - решено через целое число
// System.Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// for (int i = 0; i < x; i++)
// {
//    if (x/10>0)
//    {
//     x = x/10;
//     count++;
//    } 
//    else
//    {
//     break;
//    }
// }
// System.Console.WriteLine(count);

// Программа выдвет произведение чисел от 1 до X.
// System.Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// if (x!=0)
// {
//     for (int i = 1; i < x+1; i++)
// {
//     result = result * i; 
// }
// System.Console.WriteLine($"Произведение всех чисел от 1 до {x} равно {result}");
// }
// else
// {
//     System.Console.WriteLine($"Произведение всех чисел от 1 до {x} равно 0");
// }

// Программа выводит массив из 8 элементов заполненый 0 и 1 в случайном порядке

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}

int[] array = GetArray(8);
System.Console.WriteLine($" [ {String.Join(", ",array)} ] ");