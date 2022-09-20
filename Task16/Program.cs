// Напиши программу, где вводим три числа, а потом выводим сумму только положительных чисел.
Console.Write("Введите первое число ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int n3 = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (n1 >= 0) sum = sum + n1;
if (n2 >= 0) sum = sum + n2;
if (n3 >= 0) sum = sum + n3;

Console.WriteLine(sum);
