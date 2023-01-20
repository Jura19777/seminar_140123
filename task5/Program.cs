//Показать последнюю цифру трёхзначного числа
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse (Console.ReadLine());

int b = a%100;
int x = b%10;

Console.Write("Последнее число "+a+" будет: "+x);