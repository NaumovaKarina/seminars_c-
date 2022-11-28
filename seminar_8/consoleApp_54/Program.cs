//: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
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

int GetMaxItemIndex([,] array,int i);
{
 int index=-1;   
 int max=array[i,1];   
 for (int j=0; j<array.GetLength(1); j++)
    { 
        if (array[i,j]>max) 
        {
            max=array[i,j];
            index=j;
        }   
        Console.WriteLine($"для {i}-ой строки максимальный элемент {max} с индексом {index}");
    }
  Console.WriteLine();
 return index;
  }

void SortRow([,] array,int i);
int temp;
int maxindex=GetMaxItemIndex(array);
for (int j=0; j<array.GetLength(1); j++)
    { 
       temp=array[i,j];
       array[i,j]=array[i,maxindex];
       array[i,maxindex]=temp;
    }





Console.WriteLine("Введите M:");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n=Convert.ToInt32(Console.ReadLine());
int [,] array=new int[m,n];
FillArrayRandom(array);

