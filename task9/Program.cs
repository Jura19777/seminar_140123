//Выяснить, кратно ли число заданному, если нет, вывести остаток
Console.Clear();
Console.Write("Введите число которое будем проверять на кратность: ");
int a = int.Parse (Console.ReadLine());
Console.Write("Введите число на которое будем делить: ");
int b = int.Parse (Console.ReadLine());

if (a%b==0)
{
    Console.WriteLine("Число "+a+" кратно числу "+b);
}
else
{
    Console.WriteLine("Число "+a+" некратно числу "+b+", остаток от деления будет "+a%b);
}