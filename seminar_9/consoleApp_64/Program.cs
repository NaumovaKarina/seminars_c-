// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
int numberR(int n)
{ 
    if (n==1)
    {
        return 1;
    }
Console.Write(n);
Console.Write(" ");
return numberR(n-1);   
}


Console.WriteLine("Введите N:");
int n=Convert.ToInt32(Console.ReadLine());
int result=numberR(n);
Console.WriteLine(result);


