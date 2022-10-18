/* на вход принимает два числа 
выдаёт, какое число большее, а какое меньшее*/
Console.WriteLine("Введите число А");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b=Convert.ToInt32(Console.ReadLine());
if (a >= b)
{ 
 if (a > b) 
 {
  Console.WriteLine("А-большее число, B-меньшеее число");
 }  
 else Console.WriteLine("Числа одинаковые");
}
else
{
  Console.WriteLine("А-меньшее число, B-большее число");  
}
/*int count = 0;
while(count < 10)
{
int what = new Random().Next(0, 3);
if (what == 0)
{
x = (x + xa) / 2;
y = (y */