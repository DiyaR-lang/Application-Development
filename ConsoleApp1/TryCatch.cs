using System;

namespace ConsoleApp1
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine() ?? ""; 

                int number = Convert.ToInt32(input);
                Console.WriteLine($"Converted number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

            Console.Write("\nEnter your password: ");
            string password = Console.ReadLine() ?? "";

            try
            {
                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }
                else
                {
                    Console.WriteLine("Password satisfied the requirement");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();

        }
    }
}