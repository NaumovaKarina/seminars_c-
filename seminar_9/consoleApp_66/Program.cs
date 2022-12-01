//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumInGap(int m, int n)
{ 
    if (m==n)
    {
        return m;
    };
 
return SumInGap(m,n-1)+n;   
}
Console.WriteLine("Введите M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n=Convert.ToInt32(Console.ReadLine());
if (m>n)
  { int temp=n;
   n=m;
   m=temp;
  }
 
int result=SumInGap(m,n); 
Console.WriteLine(result);