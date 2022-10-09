// Напишите программу, которая по заданному номеру четверти, 
//показывает диапозон возможных координат точек в этой четверти (x и y)

static void Quarter(int quarter)
{
    if (quarter == 1)
        Console.WriteLine("X > 0 и Y > 0");
    else if (quarter == 2)
        Console.WriteLine("X < 0 и Y > 0");
    else if (quarter == 3)
        Console.WriteLine("X < 0 и Y < 0");
    else if (quarter == 4)
        Console.WriteLine("X > 0 и Y < 0");
    else
        Console.WriteLine("Некорректно введена четверть");
}

int quarter;

Console.Write("Введите номер четверти: ");
quarter = int.Parse(Console.ReadLine() ?? "");

Quarter(quarter);



