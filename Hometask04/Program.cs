Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine(a);
}
if (b > a && b > c)
{
    Console.WriteLine(b);
}
if (c > b && c > a)
{
    Console.WriteLine(c);
}