// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num / 100;
int num2 =(num / 10) % 10;
int num3 = num%10;


while (num < 100 || num > 1000)

    if (num < 100)
    {
        Console.WriteLine("Ошибка. Вы ввели число меньше трех цифр. ");
        return;  
    }
else
    {
        Console.WriteLine("Ошибка. Вы ввели число больше трех цифр. ");
        return;
    }


Console.WriteLine("Второе число :" + num2);