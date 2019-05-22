using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplecalculator
{
    class Program
    {
        //program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation.
        static void Main(string[] args)
        {
            int Num1, Num2, result;
            char option;
            Console.Write("Enter the First Number : ");
            Num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Operation you want to perform : ");
            option = char.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            Num2 = int.Parse(Console.ReadLine());

            switch (option)
            {
                case '+':
                    result = Num1 + Num2;
                    Console.WriteLine("The result of Addition is : {0}", result);
                    break;
                case '-':
                    result = Num1 - Num2;
                    Console.WriteLine("The result of Subtraction is : {0}", result);
                    break;
                case '*':
                    result = Num1 * Num2;
                    Console.WriteLine("The result of Multiplication is : {0}", result);
                    break;
                case '/':
                    result = Num1 / Num2;
                    Console.WriteLine("The result of Division is : {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
        }

        }
    }
