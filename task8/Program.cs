//Удалить вторую цифру трёхзначного числа
Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = int.Parse (Console.ReadLine());

int b1 = a%100;
int b3 = b1%10;
int b2 = (b1-b3)/10;

Console.WriteLine("Вторая цифра трехзначного числа "+b2+", удаляем, результат: "+a/100+" "+b3);