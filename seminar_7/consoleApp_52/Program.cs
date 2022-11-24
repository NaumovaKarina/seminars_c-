﻿// Запросите от пользователя размерности двумерного массива.
// Напишите метод для заполнения массива случайными числами. 
//Напишите метод для поиска ср. арифметического значения каждого столбца.
void FillArrayRandom(int[,] array)
{
  for (int i=0; i<array.GetLength(0); i++)
  { 
    for (int j=0; j<array.GetLength(1); j++)
    { 
        array[i,j]=new Random().Next(1,100);
        Console.Write(array[i,j]+" ");
    }
  Console.WriteLine();
  }
}

int [] GetAverage(int[,] array)

{Console.WriteLine("Промежуточные суммы построчно");
 int [] sum=new int[array.GetLength(1)];
 
 for (int i=0; i<array.GetLength(0); i++)
  { 
    for (int j=0; j<array.GetLength(1); j++)
    { 
        sum[j]=sum[j]+array[i,j];
        Console.Write(sum[j]+" ");
    }
   Console.WriteLine();

  }
  Console.WriteLine("Среднее арифметическое для каждого столбца:");
  for (int j=0; j<array.GetLength(1); j++)
    { 
        sum[j]=sum[j]/array.GetLength(0);
        Console.Write(sum[j]+" ");
    }
 return sum;
}
Console.WriteLine("Введите M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n=Convert.ToInt32(Console.ReadLine());
int [,] array=new int[m,n];
FillArrayRandom(array);
int [] Average=GetAverage(array);
