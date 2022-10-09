Console.Write("Введите номер дня недели: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

if (userNumber == 1)
{
    Console.Write(userNumber + " -> Понедельник");
}
else if (userNumber == 2)
{
    Console.Write(userNumber + " -> Вторник");
}
else if (userNumber == 3)
{
    Console.Write(userNumber + " -> Среда");
}
else if (userNumber == 4)
{
    Console.Write(userNumber + " -> Четверг");
}
else if (userNumber == 5)
{
    Console.Write(userNumber + " -> Пятница");
}
else if (userNumber == 6)
{
    Console.Write(userNumber + " -> Суббота");
}
else if (userNumber == 7)
{
    Console.Write(userNumber + " -> Воскресенье");
}
else
{
    Console.Write("В неделе всего 7 дней, перезапустите программу!");
}
