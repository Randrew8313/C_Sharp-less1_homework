// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int numberA = new Random().Next(1, 100);
Console.Write("Первое число ");
Console.WriteLine(numberA);

int numberB = new Random().Next(1, 100);
Console.Write("Второе число ");
Console.WriteLine(numberB);

if(numberA < numberB)
{
    Console.Write("Меньшее число ");
    Console.WriteLine(numberA);
    Console.Write("Большее число ");
    Console.WriteLine(numberB);
}
else if(numberA > numberB)
{
    Console.Write("Меньшее число ");
    Console.WriteLine(numberB);
    Console.Write("Большее число ");
    Console.WriteLine(numberA);
}
else
{
    Console.WriteLine("Числа равны!");
}
