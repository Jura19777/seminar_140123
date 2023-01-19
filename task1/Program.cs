Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse (Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse (Console.ReadLine());
if (b*b==a)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число НЕявляется квадратом второго числа");
}
