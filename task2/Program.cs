//По заданному номеру дня недели вывести его название
Console.Clear();
Console.Write("Введите день недели [1..7]: ");
int a = int.Parse (Console.ReadLine());

if (a==1)
{
    Console.WriteLine("День недели - понедельник");
}

if (a==2)
{
    Console.WriteLine("День недели - вторник");
}

if (a==3)
{
    Console.WriteLine("День недели - среда");
}

if (a==4)
{
    Console.WriteLine("День недели - четверг");
}

if (a==5)
{
    Console.WriteLine("День недели - пятница");
}

if (a==6)
{
    Console.WriteLine("День недели - суббота");
}

if (a==7)
{
    Console.WriteLine("День недели - воскресенье");
}
