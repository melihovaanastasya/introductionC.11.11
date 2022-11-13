// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int a=Convert.ToInt32 (Console.ReadLine());
int b,c;
b=a%10;
c=a/10;
if (b>c) System.Console.WriteLine(b);
else System.Console.WriteLine(c);