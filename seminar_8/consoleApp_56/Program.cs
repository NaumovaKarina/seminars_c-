// Задайте прямоугольный двумерный массив.
// Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов

void FillArrayRandom(int[,] array)  /*заполнение массива случайными числами*/
{
  for (int i=0; i<array.GetLength(0); i++)
  { 
    for (int j=0; j<array.GetLength(1); j++)
    { 
        array[i,j]=new Random().Next(1,5);
        Console.Write(array[i,j]+" ");
    }
  Console.WriteLine();
  }
}

int GetElementsMinSum(int[,] array) //поиск строки с минимальной суммой элементов

{
 int sum=0;
 int stroka=0;
 for (int i=0; i<1; i++)
  { for (int j=0; j<array.GetLength(1); j++)
     { 
        sum=sum+array[i,j];
     }
     Console.WriteLine($"Сумма элементов первой строки: {sum}");
  }
 for (int i=1; i<array.GetLength(0); i++)
  { 
    int temp=0;
    for (int j=0; j<array.GetLength(1); j++)
    { 
        temp+=array[i,j];
     }
   Console.WriteLine($"Сумма элементов {i+1} строки:{temp}");
   if (temp<sum)
     { 
        sum=temp;
        stroka=i+1;
     }
  }  
return stroka;
  }
     

Console.WriteLine("Введите количество строк M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов N:");
int n=Convert.ToInt32(Console.ReadLine());
while ((m==n)&&(m<=1)&&(n<=1))
  { 
   Console.WriteLine("Попробуйте поменять размерность. М и N должны быть разными и больше 1");
   Console.WriteLine("Введите количество строк M:");
   m=Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите количество столбцов N:");
   n=Convert.ToInt32(Console.ReadLine()); 
 
  };
int [,] array=new int[m,n];
FillArrayRandom(array);
int result=GetElementsMinSum(array);
if (result==0) 
 {
    Console.WriteLine($"наименьшая сумма элементов в 1-ой строке");
 }
 else Console.WriteLine($"наименьшая сумма элементов в {result}-ой строке");