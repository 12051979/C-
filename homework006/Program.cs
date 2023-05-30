// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int num3 = number % 10;

if (number <= 100)
        {
            Console.WriteLine("Введено не верное число, вы ввели число меньше трех цифр. ");
            return; 
        }
    
else if (number >= 1000)
        {
            Console.WriteLine("Введено не верное число, вы ввели больше трех цифр. ");
            return; 
        }
    
Console.WriteLine("Третья цифра числа: " + num3);
