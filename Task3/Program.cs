// На входе 2 числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите первое число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA % numB == 0) Console.Write("кратно");
else Console.Write($"не кратно, остаток {numA % numB}");
