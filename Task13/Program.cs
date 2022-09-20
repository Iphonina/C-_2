// Задача13. Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

if (x <= 99) Console.Write("третьей цифры нет");
else if (x < 1000) Console.Write(x%10);
else 
{
    while(x >= 1000)
    {
        x/=10;
    }
    Console.WriteLine(x%10);
}
    




