/* 
 Author: Stephanie McKenzie
 Date: February 5, 2023
 Description: Deliverable 4 Arrays
*/

using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // Delcaring variables and arrays
            int size = 25;
            int [] fibonacci = new int[size];

            // Initialize fibonacci series         
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            fibonacci[2] = 1;


            for (int i = 0; i< size; i++)
            {
                if (i > 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                Console.WriteLine("Fibonacci Number (" + i + ") = " + fibonacci[i]);
            }
        }
    }
}