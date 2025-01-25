/*
 Author: Victor Flores
Course: COMP-003A
Faculty: Jonathon Cruz
Purpose: Demonstrate iterative statements in C#*/
using System.Runtime.InteropServices;

namespace COMP003A.LectureActivity3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iterative Statement Demo!");

            //prompt for positive integer
            int num;
            Console.Write("Enter a positive integer to generate its multipliction table: ");
            num = int.Parse(Console.ReadLine());

            //generate multiplication table using a for loop
            Console.WriteLine($"Multiplication table for {num}:");
            /* loop to generate the multiplication table
             first statement initializes the loop variable i to 1
            second statement specifies the condition for the loop to continue
            third statement oncreases the loop variable i by 1*/
            for (int i = 1; i <= 10; i++)
            {
                //display the multiplication table
                Console.WriteLine($"{i} x {num} = {i * num}");
            }

            //display table in reverse using a while loop 
            Console.WriteLine("\nReverse Multiplication Table:");
            int reverse = 10; //idicate to start at 10
            //loop to generate the multiplication table in reverse 
            while (reverse > 0)
            {
                //display the multiplication table in reverse
                Console.WriteLine($"{reverse} x {num} = {reverse * num}");
                //decrement reverse
                reverse--;
            }
        }
    }
}
