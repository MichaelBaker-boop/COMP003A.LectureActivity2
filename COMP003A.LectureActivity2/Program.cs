﻿// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: A program demonstrating statements, variables, and operators.
namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Step 3.1: Declare and initialize variables
            string userName;
            int userAge;
            double productPrice;
            bool isStudent;

            Console.Write("Enter your name: ");
            userName = Console.ReadLine(); // Read and assign user's input to username

            Console.Write("Enter your age: ");
            userAge = int.Parse(Console.ReadLine()); // Convert and assign input to userAge

            Console.Write("Enter the price of a product: ");
            productPrice = double.Parse(Console.ReadLine()); // Convert and assign input to productPrice

            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine()); // Convert and assign input to isStudent

            // 3.2 Perform Calculations
            int futureAge = userAge + 5; // Calculate user age in 5 years
            bool isAdult = userAge >= 18; // Determine if user is 18+
            bool isAdultStudent = isStudent && isAdult; // Determine if the user is student AND an adult

            // 3.3 Display outputs using string interpolation
            Console.WriteLine($"\nHello, {userName}!"); // Greet user with their name
            Console.WriteLine($"You are currently {userAge} years old. In 5 years, you will be {futureAge}."); // Display current and future age
            Console.WriteLine($"Are you 18 or older? {isAdult}"); // Display if user is 18+
            Console.WriteLine($"Are you both a student and 18 or older? {isAdultStudent}"); // Display if user is adult and student

        }
    }
}
