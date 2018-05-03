using System;
using System.ComponentModel;
using System.Diagnostics;
using ClassLibrary1;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = new Calculator().Add(20, 30);
            var test2 = new Calculator().Substract(20, 30);
            var test3 = new Calculator().Multiply(20, 30);
            var test4 = new Calculator().Divide(20, 40);

            var result = 5 + 7;
            Console.WriteLine("Сложение a + b =  " + result);
            Console.WriteLine("Проверка результата сложения с использованием класса:  =  " + test);
            Console.WriteLine("Проверка результата вычитания с использованием класса:  =  " + test2);
            Console.WriteLine("Проверка результата умножения с использованием класса:  =  " + test3);
            Console.WriteLine("Проверка результата деления с использованием класса:  =  " + test4);
        }
    }
}