double Distance(int a1, int b1, int c1, int a2, int b2, int c2)
{
    int side1 = a1 - a2;
    int side2 = b1 - b2;
    int size3 = c1 - c2;
    double distance = (side1*side1+side2*side2+size3*size3);
    double pow = Math.Sqrt(distance);
    return pow;
}

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine(result);