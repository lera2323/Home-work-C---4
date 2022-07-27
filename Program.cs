
using System;

namespace ConsolApp
{
    class Program
    {
        static void Main (string[]args)
        {
            //Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B
         
         int number = 3;
         int power = 5;
         int result = number;
         int count = 1;

         while (count <= power)
         {
             result *= number;
             count++;
         }
         Console.WriteLine ($"Число {number} в степени {power} = {result}");
        }
    }
}