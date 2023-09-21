Console.WriteLine("Введите пятезначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10000;
int c = a % 10;
int x1 = a / 1000;
int x2 = x1 % 10;
int y1 = a / 10;
int y2 = y1 % 10;
if(b == c && x2 == y2)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}

