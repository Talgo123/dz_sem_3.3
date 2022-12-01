Console.Clear();

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double EnterPointCoordinate(string str)
{
    Console.WriteLine(str);
    double number1 = double.Parse(Console.ReadLine());
    return number1;
}

void FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)+ (z2-z1) * (z2-z1));
    double roundedDistance = Math.Round(distance, 2); // округлил цифры после запятой
    Console.WriteLine($"Расстояние между двумя точками в 3D пространстве = {roundedDistance}");
}


double xA = EnterPointCoordinate("Введите x координату точки А");
double yA = EnterPointCoordinate("Введите y координату точки А");
double zA = EnterPointCoordinate("Введите z координату точки А");

double xB = EnterPointCoordinate("Введите x координату точки В");
double yB = EnterPointCoordinate("Введите y координату точки В");
double zB = EnterPointCoordinate("Введите z координату точки А");

FindDistance(xA, yA,zA, xB, yB, zB);

