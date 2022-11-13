// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.

System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
if (a>b) System.Console.WriteLine($"{a} - максимальное число");
else System.Console.WriteLine($"{b} - максимальное число");