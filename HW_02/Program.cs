// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * x) + b2;
    Console.WriteLine($"результат ({x}; {y})");
}

double EnterData(string text)
{
    Console.Write(text);
    double number = double.Parse(Console.ReadLine());
    return number;
}

Console.WriteLine("чтобы найти точку пересечения двух прямых");
double b1 = EnterData("Введите точку b1: ");
double k1 = EnterData("Введите точку k1: ");
double b2 = EnterData("Введите точку b2: ");
double k2 = EnterData("Введите точку k1: ");

IntersectionPoint(b1, k1, b2, k2);