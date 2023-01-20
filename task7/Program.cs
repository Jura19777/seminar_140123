//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Random rnd = new Random();
int x  = rnd.Next(10, 100);
Console.WriteLine("Задано число: "+x);

int s2 = x%10;
int s1 = (x-s2)/10;

if (s1>s2)
{
    Console.WriteLine("Число "+s1+" больше "+s2);
}
else
{
    Console.WriteLine("Число "+s2+" больше "+s1);
}