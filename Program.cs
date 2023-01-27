/* int a = 10;
int b = 12;
int c = 10;
int d = 12;
int e = 10;
int f = 12;
int g = 10;
int m = 12;
int l = 14;

int max = a;
if (b > max) max = b;
if (c > max) max = c;

if (d > max) max = d;
if (e > max) max = e;
if (f > max) max = f;

if (g > max) max = g;
if (m > max) max = m;
if (l > max) max = l; 

Console.WriteLine(max); */

/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int a;
int.TryParse(Console.ReadLine()!, out a); //TryParse преобразует строковое представление числа в формате//

Console.WriteLine($"{a}\n{a / 10 % 10}");