using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutiplecatchwithsingleTRY
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Code that may throw exceptions
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[4]); // This will throw an IndexOutOfRangeException
                int result = 10/2; // This will throw a DivideByZeroException
            }
            catch (IndexOutOfRangeException ex)
            {
                // Handle the IndexOutOfRangeException
                Console.WriteLine("Index out of range: " + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle the DivideByZeroException
                Console.WriteLine("Attempted to divide by zero: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other type of exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
