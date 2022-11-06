/* принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным */
Console.WriteLine("Введите цифру от 1 до 7");
int number=Convert.ToInt32(Console.ReadLine());
if (number>=1 & number<=7)
 {
    if (number==6 | number==7)
         Console.WriteLine("Выходной");
    else Console.WriteLine("Будни");
   }
else Console.WriteLine("Этим числом нельзя обозначить день недели");