// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int n = new Random().Next(10, 100);
Console.WriteLine(n);

int a = n / 10;
int b = n % 10;

if (a > b) Console.Write(a);
else Console.Write(b);
