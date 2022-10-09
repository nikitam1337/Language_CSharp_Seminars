Console.Clear();
int X, Y;

try
{
    Console.Write("Введите X: ");
    X = int.Parse(Console.ReadLine() ?? "");
    
    Console.Write("Введите Y: ");
    Y = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

