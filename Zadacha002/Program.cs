﻿int a, b, c;

Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);


Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);


Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out c);

int max = a;
if(b > max)
max = b;
if(c > max)
max = c;

Console.WriteLine($"Максимальное число: {max}");