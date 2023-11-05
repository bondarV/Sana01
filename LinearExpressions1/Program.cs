double a, b, c, d, x, y, z, r;
Console.WriteLine("Введiть значення,якi пропонує ввести додаток,щоб вирахувати вирази рiзних змiн");
Console.WriteLine("Введiть значення a =");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть значення b =");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть значення c =");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть значення d =");
d = Convert.ToDouble(Console.ReadLine());
x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a * a / (b * b);
y = 5 * (a + b) * (c - d) / (1.0 / 2 * c) + d * d * (a * a - b * b) / (b - a);
z = (Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
r = (1 / 2.0 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + (1 / (a - c));
if (c * d != 0 && c - d != 0 && b != 0) { Console.WriteLine("Значення змiнної х ="); Console.WriteLine(x); }
else Console.WriteLine("Знаменник виразу змiнної {x} не може дорівнювати нулю");
if (c != 0 && b != a) { Console.WriteLine("Значення змiнної y ="); Console.WriteLine(y); }
else Console.WriteLine("Знаменник виразу змiнної {y} не може дорівнювати нулю");
if (5 * a + 3 * b != 0) { Console.WriteLine("Значення змiнної z ="); Console.WriteLine(z); }
else Console.WriteLine("Знаменник виразу змiнної {z} не може дорівнювати нулю");
if (3 * c + 1 != 0 && a - c != 0) { Console.WriteLine("Значення змiнної r ="); Console.WriteLine(r); }
else Console.WriteLine("Знаменник виразу змiнної {r} не може дорівнювати нулю");
