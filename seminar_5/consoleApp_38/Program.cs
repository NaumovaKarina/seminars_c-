// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. 

double[] CreateArray(int n) //создание массива, заполненного случайными вещественными числами 
{
    double[] a = new double[n];
    for(int i = 0; i < n; i++)
    {
        int temp1= Random.Next(1, 11);
        double temp2= Convert.ToDouble(temp1)/10d ;
        a[i] = temp2;
        Console.WriteLine($"A[{i}] = "+a[i]);
    }
    return a;
}

/*int GetSumEvenIndexes(int[] array) // подсчет суммы элементов с нечётным индексом
{
   int n = array.Length;
   int sum=0;
   for(int i = 1; i < n; i=i+2)
    {
     sum=sum+array[i];
    }
   return sum;  
   }
*/
Console.WriteLine("Введите количество элементов массива");
int size=Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
//int result = GetSumEvenIndexes(array);
//Console.Write($"Сумма элементов, стоящих на нечетных позициях = {result}");