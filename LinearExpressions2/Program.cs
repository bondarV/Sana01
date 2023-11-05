using System;

double m, n, z1, z2, y, x, b, a;
Console.WriteLine("Введiть значення m =");
m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть значення n =");
n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть значення x =");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть значення b =");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть значення a =");
a = Convert.ToDouble(Console.ReadLine());
z1 = (m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n) / (Math.Sqrt(Math.Pow(m, 3) * n + n * m + m * m - m));
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
if (Math.Sqrt(Math.Pow(m, 3) * n + n * m + m * m - m) != 0) { Console.WriteLine("Значення змiнної z1 ="); Console.WriteLine(z1); }
else Console.WriteLine("Знаменник виразу змiнної {z1} не може дорівнювати нулю");
if (m != 0) { Console.WriteLine("Значення змiнної z2 ="); Console.WriteLine(z2); }
else Console.WriteLine("Знаменник виразу змiнної {z2} не може дорівнювати нулю");
Console.WriteLine("Значення змiнної y =");
Console.WriteLine(y);
