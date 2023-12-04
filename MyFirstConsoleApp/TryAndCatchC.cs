using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatchC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
                Console.WriteLine(userInputAsInt);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time."); ;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty (null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }


            Console.ReadKey();
            */

            try
            {
                Console.WriteLine("Welcome to the divide calculator! \n Please enter the first number: ");
                string num1Input = Console.ReadLine();
                Console.WriteLine("Enter the second number: ");
                string num2Input = Console.ReadLine();
                int num1 = int.Parse(num1Input);
                int num2 = int.Parse(num2Input);
                double result = num1 / num2;
                Console.WriteLine("The result is: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time."); ;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty (null)");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException, It is not allowed to divide by zero.");
            }

        }
    }
}
