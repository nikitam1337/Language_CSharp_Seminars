// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine($"Ошибка ввода!");
    }
    return number;
}

int firstNumber = EnterNumber();
int secondNumber = EnterNumber();

Console.Write($"{firstNumber}, {secondNumber} -> ");

if (firstNumber % secondNumber == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine($"не кратно, остаток {firstNumber % secondNumber}");
