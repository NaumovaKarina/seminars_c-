/* выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет */
Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
int temp=Math.Abs(number);
if (temp<100)
 {Console.WriteLine("третьей цифры нет");};
while (temp>=1000) 
 {temp=temp/10;};
temp=temp%10;  
Console.WriteLine($"третья цифра - {temp}");