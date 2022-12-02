Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("max = " + a);
    Console.Write(" min = " + b);
}
else
{
    Console.Write("max = " + b);
    Console.Write(" min = " + a);
}