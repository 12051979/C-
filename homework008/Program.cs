// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();


// Console.WriteLine("Введите пятизначное число число: ");
// int number = int.Parse(Console.ReadLine()!);

// int digit1 = number / 10000; // поиск первой цифры
// int digit2 = (number / 1000) % 10; // 
// int digit3 = (number / 100) % 10;
// int digit4 = (number / 10) % 10;
// int digit5 = number % 10;

// if (digit1 == digit5 && digit2 == digit4)
// {
//     Console.WriteLine("Число является палиндромом.");
// }
// else 
// {
//     Console.WriteLine("Число НЕ является палиндромом.");
// }

int Prompt(string msg) // работа с пользователем: метод принимает аргумент- сообщение от програмиста, возвращает число введеное пользователем. 
{
    Console.WriteLine(msg); // вывод аргумента (msg) на экран
    int number = int.Parse(Console.ReadLine()!); // создаем интовую переменную из ввода (string) пользователя
    return number; // возвращаем число в первоначальный вид
}
void ComperNumber (int arg)
{
    int digit1 = arg / 10000; // поиск первой цифры
    int digit2 = (arg / 1000) % 10; // поиск второй
    int digit3 = (arg / 100) % 10;
    int digit4 = (arg / 10) % 10;
    int digit5 = arg % 10;

    if (digit1 == digit5 && digit2 == digit4) // если, сравнение цифр
    {
    Console.WriteLine("Число является палиндромом.");
    }
    else // иначе
    {
    Console.WriteLine("Число НЕ является палиндромом.");
    }
}
int Val = Prompt("Введите пятизначное число: ");
ComperNumber(Val);