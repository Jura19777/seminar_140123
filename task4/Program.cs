Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse (Console.ReadLine());

if (a%2==1)
{
   a=a-1; 
}

Console.Write("Все четные числа от 1 до "+a+" будут:");
for (int i = 2; i < a+1; i+=2)
    {
        Console.Write(" "+i);
    }