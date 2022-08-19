/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Реализовать функцию возведения в степень самостоятельно!*/

Console.WriteLine("Введите первое число: ");
int number1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2=int.Parse(Console.ReadLine());

int Stepen (int num1)
{
    int sum=number1;
    for (int i=2;i<=number2;i++)
    {
        sum*=num1;
    }
    return sum;
}

Console.WriteLine(Stepen(number1));
