/*Задача 43: Напишите программу, которая найдёт точку пересечения двух
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}
double k1 = GetNumberFromConsole("Введите k1");
double b1 = GetNumberFromConsole("Введите b1");
double k2 = GetNumberFromConsole("Введите k2");
double b2 = GetNumberFromConsole("Введите b2");

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * x + b1);
Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
