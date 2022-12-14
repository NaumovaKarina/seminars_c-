// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. 

int[] CreateArray(int n) //создание массива, заполненного случайными числами от -100 до 100 
{
    int[] a = new int[n];
    for(int i = 0; i < n; i++)
    {
        a[i] = new Random().Next(-100,101);
        Console.WriteLine($"A[{i}] = "+a[i]);
    }
    return a;
}

int GetSumEvenIndexes(int[] array) // подсчет суммы элементов с нечётным индексом
{
   int n = array.Length;
   int sum=0;
   for(int i = 1; i < n; i=i+2)
    {
     sum=sum+array[i];
    }
   return sum;  
   }

Console.WriteLine("Введите количество элементов массива");
int size=Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
int result = GetSumEvenIndexes(array);
Console.Write($"Сумма элементов, стоящих на нечетных позициях = {result}");