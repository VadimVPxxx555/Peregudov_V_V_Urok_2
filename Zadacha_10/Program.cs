﻿//Напишите программу, которая принимает на вход 
//трехзначное число и на выходе показывает вторую
//цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
number = number / 10;
int number2 =  number % 10;

Console.WriteLine ($"{number} -> {number2} ");