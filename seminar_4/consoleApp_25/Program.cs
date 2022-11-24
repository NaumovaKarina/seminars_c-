// Возведение числа A в натуральную степень B.
int RaiseToThePowerOf(int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
   {
    result = result *A;
   }
        return result;
}
  Console.Write("Введите число A: ");
  int a= Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите натуральное число B: ");
  int b = Convert.ToInt32(Console.ReadLine());
  int c = RaiseToThePowerOf(a,b);
  Console.WriteLine($"{a}^{b}={c}");