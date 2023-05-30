// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

int Prompt (string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void ExamDay (int number)
{
    while (number <= 0 || number > 7)
    {
        Console.WriteLine("Введено неподходящее число, введите повторно: ");
        number = int.Parse(Console.ReadLine ()!);
    }
    
    if (number >= 1 && number <= 5)
    {
        Console.WriteLine("Это рабочий день. Нужен выходной. ");
    }
    
    else if (number == 6 || number == 7)
    {
        Console.WriteLine("Наконец то выходной");
    }
    
}

int number1 = Prompt("Введите число приравненное к дню недели, пример: 1 понедельник, 7 воскресенье : ");
ExamDay(number1);