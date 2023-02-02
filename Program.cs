/*
 * Author: Adam Aziane 
 * Date: 02/09/2023
 * Description: This C# application code demonstrates the use of Arrays 
                after getting input fom the user. 
*/

using System;
namespace Deliverable4
{
    internal class Program
    {
        static void Main(string[] args)

        {

               int[] fibonacci = new int[25]; 

                // Initialize fibonacci series
                 fibonacci[0] = 0;
                 fibonacci[1] = 1;   

            for (int i = 0; i < fibonacci.Length;i++)
            {
             
            if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i-2];
                }
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }

        }
    }
}
