// 8. Вывести на экран числа от -N до N

int N=Convert.ToInt32(Console.ReadLine());
int a=-N;
while (a<=N)
{
    System.Console.Write($"{a} ");
    a=a+1;
}