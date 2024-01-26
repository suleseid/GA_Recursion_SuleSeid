using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GA_Recursion_SuleSeid
{
    
    internal class Program
    {
        //Recursion - Working with Arrays

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Print Numbers from 1 to 10");
                Console.WriteLine("2. Count Down and Up");
                Console.WriteLine("3. Calculate Sum of an Array");
                Console.WriteLine("4. Fibonacci Sequence");
                Console.WriteLine("5. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n1. Printing Numbers from 1 to 10:");
                            PrintNumbersFrom1To10(1);
                            break;

                        case 2:
                            Console.WriteLine("\n2. Counting Down and Up:");
                            CountDownAndUp(5);
                            break;

                        case 3:
                            int[] numbers = { 12, 23, 4, 5, 16, 7, 32, 10 };
                            Console.WriteLine("\n3. Calculating Sum of an Array:");
                            Console.WriteLine("Array elements:");
                            foreach (int num in numbers)
                            {
                                Console.Write(num + " ");
                            }
                            int sum = CalculateSum(numbers, 0);
                            Console.WriteLine($"\nSum of the array elements: {sum}");
                            break;

                        case 4:
                            Console.WriteLine("\n4. Fibonacci Sequence:");
                            Console.WriteLine("Calculating the 10th Fibonacci number:");
                            for (int i = 0; i < 10; i++)
                            {
                                int result = Fibonacci(i);
                                Console.Write(result + " ");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Exiting the application.");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        //1. Recursion - Print Numbers from 1 to 10
        // This method prints the numbers from 1 to 10 using recursion
        // It demonstrates the simplest form of recursions

        static void PrintNumbersFrom1To10(int currentNumber)
        {
            if (currentNumber > 10) // base case
            {
                // The base case is when n is greater than 10, which stops the recursion
                return;
            }
            else // recursive call
            {
                // The recursive call is when n is less than or equal to 10,
                // which prints n and calls the method again with n + 1
                Console.WriteLine(currentNumber);
                PrintNumbersFrom1To10(currentNumber + 1);
            }
        }
        //2. Recursion - Call Stack
        // This method counts down from n to 1 and then up from 1 to n using recursion
        // It demonstrates how to use two recursive calls in one method.
        static void CountDownAndUp(int currentNumber)
        {
            // Base Case Check for Counting Down:
            // Ensure we don't continue indefinitely while counting down
            if (currentNumber == 0) // base case
            {
                // The base case is when currentNumber is equal to 1, which prints 1 and returns
                Console.WriteLine(1);
                return;

            }
            else  // Recursive Call: Recursively count down
            {
                // The recursive calls are when n is greater than 1, which prints currentNumber, calls the method with currentNumber - 1, and then prints currentNumber again
                Console.WriteLine($"Before Recursive Call: {currentNumber}");
                CountDownAndUp(currentNumber - 1);
                Console.WriteLine($"After Recursive Call: {currentNumber}");
            }
        }
        //3. Recursion - Working with Arrays
        // This method calculates the sum of the first natural numbers using tail recursion
        // It demonstrates how to return a value from a recursive method
        //Summing all the values in an array
        static int CalculateSumIterative(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //Recursive Version(Code This)

        // It uses an accumulator parameter to keep track of the sum so far
        // and passes it along with the recursive call
        static int CalculateSum(int[] arr, int index)
        {
            // Base Case: If the index is equal to the array length, return 0 (no elements to add)
            if (index == arr.Length)
            {
                return 0;
            }
            else
            {
                // Recursive Case:
                // Add the current element (at the current index) to the sum of the rest of the elements
                int currentElement = arr[index];
                int restOfTheSum = CalculateSum(arr, index + 1);
                return currentElement + restOfTheSum;
            }
        }

        //4. Recursive Method - Fibonacci Sequence
        //This Final code here will demonstrate how efficient recursive code can be to execute mathematical equations.
        static int FibonacciIterative(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int fibNMinus2 = 0; // Initialize the value for F(n-2)
            int fibNMinus1 = 1; // Initialize the value for F(n-1)
            int fibN = 0; // Initialize the value for F(n)

            for (int i = 2; i <= n; i++)
            {
                fibN = fibNMinus1 + fibNMinus2;
                fibNMinus2 = fibNMinus1;
                fibNMinus1 = fibN;
            }

            return fibN;
        }
        //Recursive Version (Code This)
        // This method calculates the nth Fibonacci number using recursion
        static int Fibonacci(int n)
        {
            // It demonstrates how to use memoization to optimize recursive methods
            // Memoization is a technique that stores the results of previous computations as an array
            // and reuses them when needed.
            // This avoids repeated calculations and improves performance
            // The base cases are when n is equal to 0 or 1, which return 0 or 1 respectively
            if (n <= 1)
            {
                return n;
            }
            else
            {
                // The recursive call is when n is greater than 1, which checks the result and returns it if found,
                // or calculates it and stores it in.
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
    
}
