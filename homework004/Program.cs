// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8




Console.WriteLine("Введите положительное число  - ");
int number1 = int.Parse(Console.ReadLine ());
int number2 = number1 * -1;
int asd = 2;

if ( number1 > 2)
    {
    while (asd <= number1)
        {
        Console.Write(asd + " ");
        asd += 2;
        }
    }
else
    {
    Console.Write("Вы ввели не верное число");
    }