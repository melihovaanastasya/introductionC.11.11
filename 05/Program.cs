// 05. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число c:");
double c=Convert.ToDouble(Console.ReadLine());
double m;
m=a;
if (b>m) m=b;
if (c>m) m=c;
System.Console.WriteLine($"{m} - максимум");