//Задача10. На входе трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число ");
int x = Convert.ToInt32(Console.ReadLine());

int a = x / 100;
int b = (x-a*100)/10;
Console.Write(b);