//Найти третью цифру числа или сообщить, что её нет
Console.Clear();
Console.Write("Введите любое число: ");
int a = int.Parse (Console.ReadLine());

if (a/100==0)
{
    Console.WriteLine("Число "+a+", третьей цифры нет");
}
else
{
    Console.WriteLine("Число "+a+" третья цифра будет "+a/100);
}