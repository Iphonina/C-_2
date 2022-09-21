// Напишите программу, которя принимает на вход 7 чисел и находит их среднее aрифметическое
int count = 7;
int[] Array = new int[count];
Console.Write("Массив: ");
int index = 0;
int sum = 0;
int averageSum = 0;

while (index < count)
{
    Array[index] = new Random().Next(1, 10);
    Console.Write(Array[index] + " ");
    index++;
}
index = 0;
while (index < count)
{
    sum = sum + Array[index];
    index++;
}
averageSum = sum/count;
Console.Write("\nСреднее арифметическое = " + averageSum);
