Console.Write("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

Console.Write("a= " + userNumber1 + ", " + "b= " + userNumber2 + " -> ");

if (userNumber1 == userNumber2 * userNumber2)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}