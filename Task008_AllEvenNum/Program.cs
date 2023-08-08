// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int num = new Random().Next(1, 10);
Console.Write("Исходное Число ");
Console.WriteLine(num);

int count = 1;

while(count <= num)
{
    if(count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}
