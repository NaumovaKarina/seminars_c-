﻿//Напишите программу, которая будет принимать от пользователя позицию (M, N) 
//двумерного массива и возвращать значение элемента, 
//стоящего в этой позиции. Если такой позиции в массиве нет,
// то сообщить об этом пользователю. 
//Сгенерировать массив случайным образом. 
//Размерность массива определить самостоятельно.
// Использование методов для заполнения массива обязательно. 
//Остальное можно реализовать в главной программе. 
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

Console.WriteLine("Введите M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n=Convert.ToInt32(Console.ReadLine());
int m1=20;
int n1=20;
int [,] array=new int[m1,n1];
FillArrayRandom(array);
while (m>m1 | n>n1)
 {
    Console.WriteLine($"Индексы больше допустимых {m1}x{n1}. Попробуйте еще ");
    Console.WriteLine("Введите M:");
    m=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N:");
    n=Convert.ToInt32(Console.ReadLine());
 }
Console.WriteLine(array[m,n]);