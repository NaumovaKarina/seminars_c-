// Подсчет суммы цифр в числе.

int GetAllDigitalSum(int number)
{
 int sum=0;
 number = Math.Abs(number); 
 int n = Convert.ToString(number).Length;
 for (int i=0; i<n; i++)
  { 
  sum=sum+number%10;
  number= number/10 ;
  }
 sum=sum+number;
 return sum;
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int AllDigitalSum = GetAllDigitalSum(N);
Console.WriteLine($"Сумма цифр в числе {N}: {AllDigitalSum}");