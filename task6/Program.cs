Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = int.Parse (Console.ReadLine());

int b = a%100;
int x = b%10;

Console.Write("Вторая цифра трехзначного числа "+a+" будет: "+(b-x)/10);