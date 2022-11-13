// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

int a=Convert.ToInt32(Console.ReadLine());
if (a/100==0) System.Console.WriteLine("NO");
else System.Console.WriteLine((a/100)%10);