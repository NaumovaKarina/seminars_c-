//из данного массива строк создать массив из строк, 
//длина которых меньше либо равна 3 символа

string[] FillArray(int n) // метод задания массива пользователем
{
    string[] a = new string[n];
    for(int i = 0; i < n; i++)
    {
        Console.Write($"A[{i}] = ");
        a[i] = Console.ReadLine();
    }
    return a;
}

void PrintArray(string[] array) // метод  вывода массива на печать
{
   int n = array.Length;
   Console.Write("[");
   for(int i = 0; i < n; i++)
    {
    Console.Write($"\"{array[i]}\"");
    if (i<(n-1)) Console.Write(", ");
     }
   Console.Write("]");  
   }


int count=0;
int j=0;
int i=0;
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());   
string[] arrayA=FillArray(n);
Console.Write("Исходный массив: ");
PrintArray(arrayA);
for (i=0; i<n; i++)
  {
    if (arrayA[i].Length<=3) count++; 
  };
string[] arrayB=new string[count];  
i=0;
for (i=0; i<n; i++)
  {
    if (arrayA[i].Length<=3) 
     { arrayB[j]=arrayA[i];
        j++;
     }
  };
Console.WriteLine();
Console.Write("Сформированный массив: ");
PrintArray(arrayB);