﻿//Запросите от пользователя размерности двумерного массива.
 //Напишите метод для заполнения массива случайными числами. 
 //Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
//Округлите значения, генерируемые Random до двух знаков после запятой.
void FillArrayRandom(double[,] array)
{
  for (int i=0; i<array.GetLength(0); i++)
  { 
    for (int j=0; j<array.GetLength(1); j++)
    { 
        array[i,j]=Math.Round(new Random().NextDouble(),2);
        Console.Write(array[i,j]+" ");
    }
  Console.WriteLine();
  }
}

Console.WriteLine("Введите M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n=Convert.ToInt32(Console.ReadLine());
double [,] array=new double[m,n];
FillArrayRandom(array);

