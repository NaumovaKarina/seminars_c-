// Задайте массив заполненный случайными положительными трёхзначными числами. 
//подсчет чётных чисел в массиве.
int[] CreateArray(int n) //создание массива, заполненного случайными положительными трёхзначными числами 
{
    int[] a = new int[n];
    for(int i = 0; i < n; i++)
    {
        a[i] = new Random().Next(100,1000);
        Console.WriteLine($"A[{i}] = "+a[i]);
    }
    return a;
}

int CountOddNumbers(int[] array) // подсчет чётных чисел в массиве
{
   int n = array.Length;
   int count=0;
   for(int i = 0; i < n; i++)
    {
     if (array[i]% 2 !=1) ++count;
    }
   return count;  
   }

Console.WriteLine("Введите количество элементов массива");
int size=Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
int CountOdds = CountOddNumbers(array);
Console.Write($"Количество четных = {CountOdds}");