// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine ("Введите к1:");
double k1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите k2:");
double k2 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите b1:");
double b1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите b2:");
double b2 = Convert.ToDouble (Console.ReadLine());


double X = IntersectionPoint1 (k1, k2, b1, b2);

double IntersectionPoint1(double a, double b, double c, double d)
{
    double x = (d - c)/(a - b);
   
    
    return x;
}


double Y = IntersectionPoint2 (k1, k2, b1, b2);

double IntersectionPoint2(double a, double b, double c, double d)
{
    
    double y = b * ((d - c)/(a - b)) + d;

    return y;
}

Console.WriteLine($"Координаты точки пересечения двух прямых: ({X:f3} , {Y:f3})");