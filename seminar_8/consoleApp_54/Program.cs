//: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
void FillArrayRandom(int[,] array) //заполнение двумерного массива случайными числами
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

/*int GetMaxItemIndex(int[,] array,int i, int j1, int j2) // поиск максимального элемента в заданной строке в промежутке между заданными колонками
{
 int index=0;   
 int max=array[i,j1];   
 for (int j=j1; j<j2; j++)
    { 
        if (array[i,j]>max) 
        {
            max=array[i,j];
            index=j;
        }   
        //Console.WriteLine($"для {i+1}-ой строки максимальный элемент {max} с индексом {index}");
    }
  Console.WriteLine($"для {i+1}-ой строки максимальный элемент {max} с индексом {index}");  
  Console.WriteLine();
 return index;
  }
*/
void SortRow(int[,] array,int i)
{
  int temp;
  for (int j=0; j<array.GetLength(1); j++)
    { 
      for (int k=j+1; k<array.GetLength(1); k++)
      {
       if (array[i,j]<array[i,k])
         {
          temp=array[i,j];
          array[i,j]=array[i,k];
          array[i,k]=temp;
         } 
      }
     // Console.Write($"{array[i,j]} " );
    }
};


void PrintArray(int[,] coll)  // функция  вывода массива на печать
{
  for (int i=0; i<coll.GetLength(0); i++)
  { 
    for (int j=0; j<coll.GetLength(1); j++)
    { 
        Console.Write(coll[i,j]+" ");
    }
  Console.WriteLine();} 
};
   



Console.WriteLine("Введите M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n=Convert.ToInt32(Console.ReadLine());
int [,] array=new int[m,n];
FillArrayRandom(array); 
Console.WriteLine();
for (int i=0; i<array.GetLength(0); i++)
  { 
    SortRow(array,i);
    //int index=GetMaxItemIndex(array,i, 0, array.GetLength(1));
    //Console.WriteLine($"индекс максимального элемента {i+1}-ой строки: {index}");
  Console.WriteLine();
  }  
PrintArray(array);
  