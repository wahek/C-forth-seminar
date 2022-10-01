// ВСЕ ЗАДАЧИ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите первоe и второе число:");
// int A = int.Parse(Console.ReadLine()!);
// int B = int.Parse(Console.ReadLine()!);
// Console.Write($"Число {A} в степени {B} = {sqr(A)}");

// int sqr(int a){
//     int A = a;
//     for (int i = 2; i <= B; i++){
//         A = A * a;
//     }
//     return A;
// }
    


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число:");
// string num = Console.ReadLine()!;
// Console.WriteLine($"Сумма цифр в числе {num} ровно {DoSum(num)}");

// int DoSum(string A){
//     int sum = 0;
//     int size = A.Length;
//     for (int i = 0; i < size; i++){
//         int MyNum = Convert.ToInt32(A[i]);
//         Console.WriteLine(A[i]);
//         sum += MyNum;
//     }
//     return sum; 
// }

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {num} ровно {DoSum1(num)}");

int DoSum1(int A){
    int sum = 0;
    for(int i = 0; i < A; A /= 10){
        sum += (A%10);
    }
    return sum;
}

// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
