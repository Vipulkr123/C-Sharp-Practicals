﻿using System.Text.RegularExpressions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                string? Input_1;
                string? Input_2;
                bool isNumber;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Please Enter First number : ");
                        Input_1 = Console.ReadLine();
                        if (!Regex.IsMatch(Input_1, @"^[+-]?\d+(\.\d+)?$"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have not entered a number !");
                        }
                    }
                    while (!Regex.IsMatch(Input_1, @"^[+-]?\d+(\.\d+)?$"));
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Please Enter Second number : ");

                        Input_2 = Console.ReadLine();
                        if (!Regex.IsMatch(Input_2, @"^[+-]?\d+(\.\d+)?$"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have not entered a number !");
                        }
                    } while (!Regex.IsMatch(Input_2, @"^[+-]?\d+(\.\d+)?$"));
                    double Number_1 = Convert.ToDouble(Input_1);
                    double Number_2 = Convert.ToDouble(Input_2);
                    if (Number_2 != 0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("****************** Result *********************");
                        Console.WriteLine();
                        Console.WriteLine($"The sum of {Number_1} and {Input_2} is {Math.Round((Number_1 + Number_2), 4)}");
                        Console.WriteLine($"The subtraction  of {Number_1} and {Input_2} is {Math.Round((Number_1 - Number_2), 4)}");
                        Console.WriteLine($"The multiplication of {Number_1} and {Input_2} is {Math.Round((Number_1 * Number_2), 4)}");
                        Console.WriteLine($"The division  of {Number_1} and {Input_2} is {Math.Round((Number_1 / Number_2), 4)}");
                        Console.WriteLine();
                        Console.WriteLine("***********************************************");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"The {Input_1} can't Divide by 0");
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Do you want to continue : y/n => ");
                }
                while (Console.ReadKey().KeyChar.ToString().ToLower() == "y");
            }
        }
    }
}