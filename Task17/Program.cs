//Определить, присутствует ли в заданном массиве некоторое число. Массив задается автоматически, искомое число загадывается компьютером
int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;
Console.Write("ищем = ");
Console.WriteLine(find);
Console.Write("Массив: ");

while(index < count)
{
    array[index] = new Random().Next(1, 22);
    Console.Write(array[index] + " ");
    index++;
}
Console.WriteLine(index);
index = 0;
while(index < count)
{
    if(array[index] == find)
    {
        Console.WriteLine("Такой элемент есть");
    }
    index++;
}
Console.WriteLine("END");