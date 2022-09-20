//Задача 15. Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 | num == 7) Console.Write("да");
else if (num >=1 && num <=5) Console.Write("нет");
else Console.Write("нет такого дня недели");