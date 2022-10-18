// проверка числа на четность
Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
int max=a;
if (a%2==0) 
 {
    Console.WriteLine($"Число {a} четное");
 }  
else
Console.WriteLine($"Число {a} нечетное");
