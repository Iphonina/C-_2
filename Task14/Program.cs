// Задача 14. На вход число и проверяет кратно ли оно одновременно 7 и 23
//int n = new Random().Next();
//Console.WriteLine(n);
int n = 320;
if (n % 7 == 0 && n % 23 == 0) Console.WriteLine("да, кратно");
else Console.WriteLine("нет");