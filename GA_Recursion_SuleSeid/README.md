Guided Assignment - Exploring Recursion in C#
Introduction
This assignment delves into the concept of recursion in C#, exploring its application through various examples. Recursion is a powerful programming technique where a method calls itself to solve a problem. It's particularly useful for tasks that can be broken down into similar subtasks.

Key Concepts
Base Case: The condition under which the recursion stops.
Recursive Call: The method calling itself with a modified argument.
Stack Behavior: Understanding how recursive calls are stacked and unwound.
Detailed Requirements
Project Setup (20 Points):

Create a new console application in your IDE.
Name the project GA_Recursion_YourName (replace "YourName" with your actual name).
Understanding Recursion (15 Points):

Write a brief explanation of what recursion is and how it works in C#.
Describe the importance of the base case in recursion.
Implementing Recursion (15 Points):

Implement four recursive methods:
PrintNumbersFrom1To10
CountDownAndUp
CalculateSum
Fibonacci
Each method should demonstrate a different aspect of recursion.
Add clear comments explaining the code's functionality.
Explanation of Algorithm Logic (15 Points):

Provide comments explaining:
The purpose of the base case and the recursive call.
How the call stack behaves in recursive calls.
The role of each method in demonstrating recursion.
Optimizing Recursive Processes (15 Points):

Implement and explain any optimizations possible in recursive methods.
Discuss the role of these optimizations in improving performance and preventing issues like stack overflow.
Code Testing and Output Accuracy (5 Points):

In the Main method, create test cases to demonstrate each recursive method.
Verify that the output is correct for each method.
Submission (5 Points):

Upload the complete project to GitHub.
Make the repository public and include all necessary files.
Provide the GitHub repository link in your Canvas submission.
Total (100 Points):

Each section is required.
Points are awarded based on meeting the detailed requirements accurately.
Follow these requirements closely to meet all the criteria outlined in the rubric for your assignment.

Step By Step
1. Recursion - Print 1 to 10
Iterative Version (Don't Code)

for (int i = 1; i <= 10; i++) 
	{ Console.WriteLine(i); }
Step 1 - The Break Case
Recursive Method - Print 1 - 10
Step 1: We check if the current number (currentNumber) is less than or equal to 10. If this condition is true, we proceed with the following steps.
    static void PrintNumbersFrom1To10(int currentNumber)
    {
        if (currentNumber <= 10)
        {
            // Step 1: Check if the current number is less than or equal to 10
            // If true, proceed with the following steps.
        }
    }
Step 2 - Print the Current Number
Step 2: We print the currentNumber to the console.
    static void PrintNumbersFrom1To10(int currentNumber)
    {
        if (currentNumber <= 10)
        {
            // Step 2: Print the current number
            Console.WriteLine(currentNumber);
        }
    }
Step 3 - Print the Current Number
Step 3: We increase the currentNumber by 1 and store it in a variable called nextNumber.
    static void PrintNumbersFrom1To10(int currentNumber)
    {
        if (currentNumber <= 10)
        {
            Console.WriteLine(currentNumber);

            // Step 3: Increase the current number by 1
            int nextNumber = currentNumber + 1;
        }
    }
Step 4 - Print the Current Number
Step 4: We make a recursive call to PrintNumbersFrom1To10 with the nextNumber as the argument. This means we repeat the process with the next number.
    static void PrintNumbersFrom1To10(int currentNumber)
    {
        if (currentNumber <= 10)
        {
            Console.WriteLine(currentNumber);
            // Step 3: Increase the current number by 1
            int nextNumber = currentNumber + 1;
            // Step 4: Recursively call the function with the next number
            PrintNumbersFrom1To10(nextNumber);
        }
    }
Step 5 - Print the Current Number
Step 5: When the recursion reaches 11, it automatically stops because the condition in Step 1 is no longer true, and no more numbers are printed.
    static void PrintNumbersFrom1To10(int currentNumber)
    {
        if (currentNumber <= 10)
        {
            // Step 1: Check if the current number is less than or equal to 10
            // If true, proceed with the following steps.

            // Step 2: Print the current number
            Console.WriteLine(currentNumber);

            // Step 3: Increase the current number by 1
            int nextNumber = currentNumber + 1;

            // Step 4: Recursively call the function with the next number
            PrintNumbersFrom1To10(nextNumber);

            // Step 5: When the recursion reaches 11, it stops automatically.
        }
    }
Test The Code

Test your code by calling the PrintNumbersFrom1To10(1) from main.

static void Main(string[] args)
{
	PrintNumbersFrom1To10(1);
}
Output

1
2
3
4
5
6
7
8
9
10
Explanation of a Recursion Method
Certainly, let's add numbers to the comments and explain why each of these points is important for recursive methods:

static void PrintNumbersFrom1To10(int currentNumber)
{
    // 1. Base Case Check: Ensure we don't continue indefinitely
    if (currentNumber <= 10)
    {
        // 2. Output the current number
        Console.WriteLine(currentNumber);

        // 3. Incremental Step: Move towards the base case
        int nextNumber = currentNumber + 1;

        // 4. Recursive Call: Call the function with the next number
        PrintNumbersFrom1To10(nextNumber);

        // 5. Base Case Exit: When the recursion reaches 11, it stops automatically.
    }
}
Here's why each of these points is important for recursive methods:

Base Case Check: This is crucial to prevent infinite recursion. It defines a condition that, when met, stops the recursion. Without a base case, the recursion would continue indefinitely, leading to a stack overflow.
// 1. Base Case Check: Ensure we don't continue indefinitely
if (currentNumber <= 10)
{
	// Internal Code
}
Output: The recursive method performs some useful work or computation in each recursive call. In this case, it prints the current number. Recursive methods can perform any desired operation at each step.
	// 2. Output the current number
	Console.WriteLine(currentNumber);
Incremental Step: This step modifies the input arguments or state in some way to make progress toward the base case. It ensures that the recursion moves closer to the termination condition, preventing the recursion from becoming stuck.
        // 3. Incremental Step: Move towards the base case
        int nextNumber = currentNumber + 1;
Recursive Call: The recursive method calls itself with modified arguments. This is the essence of recursion, as it allows the function to solve smaller instances of the same problem. The recursive call typically operates on a smaller or simpler subproblem.
        // 4. Recursive Call: Call the function with the next number
        PrintNumbersFrom1To10(nextNumber);
Base Case Exit: This defines the condition under which the recursion stops. When the base case is reached, the recursion naturally terminates. Without a base case exit, the recursion would continue indefinitely.
In summary, a well-structured recursive method has these elements to ensure that it terminates correctly, makes progress toward a solution, and eventually reaches the base case, preventing infinite recursion. Each of these points plays a critical role in the design of recursive algorithms.

2. Recursion - Call Stack
Step 1 - Create the Following Method
Write the following code
Call the method with an argument of 5
Run
static void CountDownAndUp(int currentNumber)
{
   // Base Case Check for Counting Down: Ensure we don't continue indefinitely while counting down
   if (currentNumber >= 1)
   {
	   Console.WriteLine($"Before Recursive Call: {currentNumber}");

	   // Recursive Call: Recursively count down
	   CountDownAndUp(currentNumber - 1);
   }
}
Expected Result

Before Recursive Call: 5
Before Recursive Call: 4
Before Recursive Call: 3
Before Recursive Call: 2
Before Recursive Call: 1
Step 2 - Counting down
Comment out the Console.WriteLine() after our if statement.
Now AFTER our recursive call, add the following line. Console.WriteLine($"After Recursive Call: {currentNumber}");
Run The Code with an argument of 5
static void CountDownAndUp(int currentNumber)
{
   // Base Case Check for Counting Down: Ensure we don't continue indefinitely while counting down
   if (currentNumber >= 1)
   {
	   // Console.WriteLine($"Before Recursive Call: {currentNumber}");

	   // Recursive Call: Recursively count down
	   CountDownAndUp(currentNumber - 1);

	   Console.WriteLine($"After Recursive Call: {currentNumber}");

	   // Print the same number while counting up
   }
}
After Recursive Call: 1
After Recursive Call: 2
After Recursive Call: 3
After Recursive Call: 4
After Recursive Call: 5
Call Stack Simplified Explanation:

Imagine a stack of plates. You can only add or remove plates from the top.

When a function is called in a program, it's like adding a new plate to the stack.
Information about that function (like variables) is put on that plate.
If that function calls another function, it's like adding another plate on top.
When a function finishes, its plate is removed (popped off), and we go back to the previous plate.
This keeps things organized and ensures we know where to go next in the program.
If we add too many plates (functions calling functions), the stack can become too tall (stack overflow), and it's a problem.
3. Recursion - Working with Arrays
Summing all the values in an array
Iterative Version (Don't Write)

static int CalculateSumIterative(int[] arr)
{
	int sum = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		sum += arr[i];
	}
	return sum;
}
Base Case: When we have reached the end of our array
Equivalent of i < arr.Length
Recursive Call: Pass in our array, and then increment the index
Pass in our array, while also passing in the next iteration of our index
When method call is closed, it's returning the current sum of values up to that point.
Return : Returns the sum of numbers current, plus the current number.
Recursive Version (Code This)

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
Run This Code
static void Main(string[] args)
{
   int[] numbers = { 12, 45, 7, 23, 9 }; // Adding 5 hardcoded numbers to the array

   Console.WriteLine("Array elements:");
   foreach (int num in numbers)
   {
	   Console.Write(num + " ");
   }

   int sum = CalculateSum(numbers, 0);
   Console.WriteLine($"\nSum of the array elements: {sum}");
}
Expected Result

Array elements: 12 45 7 23 9 
Sum of the array elements: 96
4. Recursive Method - Fibonacci Sequence
This Final code here will demonstrate how efficient recursive code can be to execute mathematical equations.

Iterative Version (Don't Write)

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
Recursive Version (Code This)

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
In this code:

The Main method sets the desired length of the Fibonacci sequence (in this case, n = 10) and then iterates from 0 to n - 1, calling the Fibonacci method for each index and printing the result.

The Fibonacci method is a recursive method that calculates the nth Fibonacci number. It has a base case for n <= 1 where it returns n. For larger values of n, it recursively calls itself with n - 1 and n - 2 and returns the sum of those two results.

Test the Code

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; // Change n to the desired Fibonacci sequence length
        Console.WriteLine($"Fibonacci sequence of length {n}:");
        for (int i = 0; i < n; i++)
        {
            int result = Fibonacci(i);
            Console.Write(result + " ");
        }
    }
}
When you run this program with n = 10, it will print the first 10 numbers of the Fibonacci sequence:

Fibonacci sequence of length 10:
0 1 1 2 3 5 8 13 21 34

