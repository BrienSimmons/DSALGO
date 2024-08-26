namespace DSALGO;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci Sequence using Loops:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(FibonacciLoop(i) + " ");
        }

        Console.WriteLine("\n\nFibonacci Sequence using Recursion:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(FibonacciRecursion(i) + " ");
        }

        Console.ReadLine();
    }

    //Loops
    static int FibonacciLoop(int n)
    {
        if (n <= 1) return n;

        int a = 0;
        int b = 1;
        int result = 0;

        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }

        return result;
    }

    //Recursion
    static int FibonacciRecursion(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
    }
}