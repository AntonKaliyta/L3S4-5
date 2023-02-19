// не принимает и не возащает  
// void Method1()
// {
// System.Console.WriteLine("Автор Антон К.");
// }
// Method1();

// принимет но не возвращает
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2("Текст");

// то же самое но выводит сообщение n раз
// void Method21(string msg, int n)
// {
//     int count = 0;
//     while (count<n)
//     {
//         System.Console.WriteLine(msg);
//         count++;
//     }
// }
// Method21("Текст 2", 5);

// не принимает но возвращает
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int x = Method3();
// System.Console.WriteLine(x); 

// принимает и возвращает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;


// }
// string res = Method4(10, "zxc");
// System.Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 0; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     System.Console.WriteLine();
// }

//Дан текст, пробелы заменить на _, к на К, С на с.

// string newText = "– Я думаю, – сказал князь, улыбаясь, – что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText2 = Replace(newText, ' ', '_');
// string newText3 = Replace(newText2, 'к', 'К');
// string newText4 = Replace(newText3, 'С', 'с');
// System.Console.WriteLine(newText4);

// Сортировка массива

int[] arr = { 1, 2, 5, 7, 8, 9, 2, 4, 5 };


