int a,b;
Console.WriteLine("Введите два числа");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if(a>b)

{
    Console.WriteLine("Первое число больше");
    Console.WriteLine("Второе число меньше");
}
else if(b>a)
{
    Console.WriteLine("Второе число больше");
    Console.WriteLine("Первое число меньше");
}

