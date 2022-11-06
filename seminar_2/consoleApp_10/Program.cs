/* принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа */ 
Console.WriteLine("Введите трехзначное число");
int number=Convert.ToInt32(Console.ReadLine());
int modul=Math.Abs(number);
while (modul < 100 | modul > 999)
  {
   Console.WriteLine("Это не трехзначное число, попробуйте еще раз");
   Console.WriteLine("Введите трехзначное число");
   number=Convert.ToInt32(Console.ReadLine());
   modul=Math.Abs(number);
  }
int a1=modul/100;
int a2=(modul-a1*100)/10;
Console.WriteLine($"Вторая цифра {a2}");