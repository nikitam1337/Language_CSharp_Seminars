// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.
// A (3,6)' B

int a1, a2, b1, b2;

a1 = Koords("Введите координату X первого числа: ");
a2 = Koords("Введите координату Y первого числа: ");
b1 = Koords("Введите координату X второго числа: ");
b2 = Koords("Введите координату Y второго числа: ");

//Console.WriteLine(a1);

double distanse = Distanse(a1, a2, b1, b2);

Console.WriteLine(Distanse);

static int Koords(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse(int a1, int a2, int b1, int b2)
{
    double result = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2));
    return result;
}
