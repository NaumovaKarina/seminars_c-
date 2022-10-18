// выдаёт максимальное из трех чисел
Console.WriteLine("Введите число А");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число С");
int c=Convert.ToInt32(Console.ReadLine());
int max=a;
if (b>max) max=b;
if (c>max) max=c; 
Console.WriteLine($"Максимальное число={max}");
