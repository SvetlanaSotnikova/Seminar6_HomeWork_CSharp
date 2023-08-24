// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
using System.Runtime.Intrinsics.X86;

int[] CreateArr(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input element {i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return arr;
}

void WriteArr(int[] arr)
{
    string strArr = string.Join(", ", arr);
    Console.Write($"{strArr} -> ");
}

int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i]) > 0)
            count++;
    }
    return count;
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArr(m);
WriteArr(arr);
Console.WriteLine($"{GetCount(arr)}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void GetPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}
Console.Write("Input value b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input value k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input value b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input value k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

GetPoint(b1,k1,b2,k2);
*/

// Написать программу, преобразующую число из десятеричной системы счисления в двоичную.

int[] DecimalToBinary(int number)
{
    if (number == 0) return new int[] { 0 };

    int[] arr = new int[32];
    int i = 0;
    while (number > 0)
    {
        arr[i] = number % 2;
        number /= 2;
        i++;
    }
    Array.Resize(ref arr, i); // уменьшение размера массива до его реальной длины
    return arr;
}
Console.Write("Enter a number in decimal: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = DecimalToBinary(num);
Console.Write($"number {num} in binary: ");
for (int i=0;i<arr.Length;i++)
{
    Console.Write(arr[i]);
}
Console.WriteLine();

// Намного упращенный вариант
Console.Write("Enter a number in decimal: ");
int number = Convert.ToInt32(Console.ReadLine());
string binNum = Convert.ToString(num, 2);
Console.Write($"number {number} in binary: {binNum} ");