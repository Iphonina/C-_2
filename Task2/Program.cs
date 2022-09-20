// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//Console.Write("Введите трехзначное число ");
//int x = Convert.ToInt32(Console.ReadLine());

int n = new Random().Next(100, 999);
int n1 = n / 100;
int n2 = n % 10;
int n3 = n2 % 10;
Console.WriteLine(n);
Console.Write($"{n1}{n3}");

//int n1 = (n/100)*10;
//int n2 = n%10;
//int n3 = n1 + n2;
//Console.WriteLine(n);
//Console.WriteLine(n3);