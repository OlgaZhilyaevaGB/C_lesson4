﻿/*Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(Summa(number));

int Summa (int mumber)
{
    int sum=0;
    while(number!=0)
    {
        sum+=number%10;
        number/=10; 
    }
    return sum;

}

