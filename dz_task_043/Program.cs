// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine("точка пересечения двух прямых, находиться с помощью уравнениями y = k1 * x + b1, y = k2 * x + b2");

int k1 = InputNumber("Введите число k1 ");
int b1 = InputNumber("Введите число b1 ");
int k2 = InputNumber("Введите число k2 ");
int b2 = InputNumber("Введите число b2 ");

double FindX(double k1, double b1, double k2, double b2)
{
    double x;
    x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double k1, double b1)
{
    double y;
    double x = FindX(k1, b1, k2, b2);
    y = k1 * x + b1;
    return y;
}

double X = FindX(k1, b1, k2, b2);
double Y = FindY(k1, b1);
System.Console.WriteLine($"Кординаты точки пересечения({X};{Y})");

