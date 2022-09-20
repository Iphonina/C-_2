Console.WriteLine("");
int n = 10;
while (n > 3)
{
    Console.WriteLine(n);
    n -= 1;
}


for (int i = 3; i < 10; i++) 
{
    int x = new Random().Next(1,100);
    Console.WriteLine($"Наша переменная {i} равна {x}");
}

