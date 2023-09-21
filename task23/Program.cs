void CubeNum(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{count} -> {count*count*count}");
        count++;
    }
}

Console.WriteLine("Введите число для нахождения куба числа:");
int number = Convert.ToInt32(Console.ReadLine());

CubeNum(number);