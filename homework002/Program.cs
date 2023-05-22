// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22




Console.WriteLine("Введите первое число их трех -");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число их трех -");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число их трех -");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > number1)
    max = number2;
if (number3 > max)
    max = number3;
Console.Write("Максимальное число " + max);
