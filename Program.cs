using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Convert a string to an integer using TryParse
                Console.Write("Enter a number: ");
                string inputNumber = Console.ReadLine();
                int number;

                if (int.TryParse(inputNumber, out number))
                {
                    // Conversion successful, multiply by 5
                    int result = number * 5;
                    Console.WriteLine($"Result after multiplying by 5: {result}");
                }
                else
                {
                    // Conversion failed, display an error message
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

                // Convert a string to a DateTime object using the Convert method
                Console.Write("Enter a date (e.g., '2023-11-08'): ");
                string inputDate = Console.ReadLine();

                try
                {
                    DateTime date = Convert.ToDateTime(inputDate);
                    // Subtract 1 month from the obtained DateTime object
                    date = date.AddMonths(-1);
                    Console.WriteLine($"Result after subtracting 1 month: {date:yyyy-MM-dd}");
                }
                catch (FormatException)
                {
                    // Handle exception if the input is not a valid date
                    Console.WriteLine("Invalid date format. Please enter a valid date.");
                }

                // Convert a string to a TimeSpan object using the Parse method
                Console.Write("Enter a time (e.g., '02:30:00'): ");
                string inputTime = Console.ReadLine();

                try
                {
                    TimeSpan time = TimeSpan.Parse(inputTime);
                    // Add 2 hours to the obtained TimeSpan object
                    time = time.Add(new TimeSpan(2, 0, 0));
                    Console.WriteLine($"Result after adding 2 hours: {time}");
                }
                catch (FormatException)
                {
                    // Handle exception if the input is not a valid time format
                    Console.WriteLine("Invalid time format. Please enter a valid time.");
                }
            Console.ReadKey();
            }
        }

    }
