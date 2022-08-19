/*Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.

5, 0, 20 -> [1, 2, 5, 7, 19]

3, 1, 35 -> [6, 1, 33]*/

Console.WriteLine("Введите длинну массива: ");
int N=int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение в массиве: ");
int a=int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в массиве: ");
int b=int.Parse(Console.ReadLine());

RandArray();

void RandArray()
{
    int []arr=new int [N];
    for (int i=0; i<arr.Length;i++)
    {
        arr[i]=new Random().Next(a,b);
        Console.Write("{0} ",arr[i]);
    }
    Console.WriteLine();
}

