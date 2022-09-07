/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Задача 43: Напишите программу, которая найдёт т.пересечения 2х прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.Write("Введите значения точки b1: "); 
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значения точки k1: "); 
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значения точки b2: "); 
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значения точки k2: "); 
double k2 = Convert.ToInt32(Console.ReadLine());
FindPoint (b1, k1, b2, k2);

//метод нахождения точки пересечения 2х прямых
void FindPoint(double B1, double K1, double B2, double K2)
{
    if((k1==k2)&&(b1==b2))
    {
        Console.WriteLine ("Данные прямые совпадают");
    }
    else if (k1==k2)
    {
        Console.WriteLine ("Данные прямые параллельны");
    }
    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = (k1*(b2-b1))/(k1-k2)+b1;
        Console.WriteLine ($"Данные прямые пересекаются, точка их пересечения ({x};{y})");
    }
    return;
}
Console.WriteLine();