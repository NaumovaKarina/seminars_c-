int[] FillArray() // метод задания массива пользователем
{
    Console.Write("N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n];
    for(int i = 0; i < n; i++)
    {
        Console.Write($"A[{i}] = ");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}

void PrintArray(int[] array) // метод  вывода массива на печать
{
   int n = array.Length;
   Console.Write("[");
   for(int i = 0; i < n; i++)
    {
    Console.Write(array[i]);
    if (i<(n-1)) Console.Write(", ");
     }
   Console.Write("]");  
   }
   
int[] array=FillArray();
PrintArray(array);