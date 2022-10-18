// вывод чётных чисел от 1 до N.
Console.WriteLine("Введите число");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа в интервале между 1 и {n}:");
if (n>=2)
{
 int i=2;
 while (i<=n)
  { 
    Console.Write(i+" ");
    i=i+2; 
  }
}
else Console.WriteLine("нет положительных четных чисел");
