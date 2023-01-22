int a, b;
string userEnter1, userEnter2;

Console.Write("Введите первое число: ");
userEnter1 = Console.ReadLine()!;

a = int.Parse(userEnter1);

Console.Write("Введите второе число: ");
userEnter2 = Console.ReadLine()!;

b = int.Parse(userEnter2);

if(a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}