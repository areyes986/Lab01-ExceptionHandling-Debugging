using System;

namespace ExceptionHandlingDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");
            StartSequence();
        }

        //StartSequence Method
        static void StartSequence()
        {
            try
            {

            Console.WriteLine("Enter a number greater than zero.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[userInput];
            Populate(numArray);
            int sumNumb = GetSum(numArray);
            int product = GetProduct(numArray, sumNumb);
            GetQuotient(product);

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Your Format Exception is: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Your Overflow Exception is: {e.Message}");
            }
        }
        
        // User inputs the number of elements into the array and is asked to enter a number array.length times
        static int[] Populate(int[] populatedArray)
        {
            for (int i = 0; i < populatedArray.Length; i++)
            {
                Console.WriteLine($"Please enter a number: {i + 1} of {populatedArray.Length}");
                string specificNumber = Console.ReadLine();
                populatedArray[i] = Convert.ToInt32(specificNumber);
            }
            return populatedArray;
        }

        // The console iterates through the array to get the sum of the elements. 
        // If the sum is less than 20, console tells them the sum is too low.
        static int GetSum(int[] sumarray)
        {
            int sum = 0;
            for (int i = 0; i < sumarray.Length; i++)
            {
                sum += sumarray[i];
            }

            if (sum < 20)
            {
                Console.WriteLine($"Value of {sum} is too low");
            }
            return sum;
        }

        // User is asked to select a number between 1 and the already stated array.length.
        // The number they chose is multiplied by the number they chose. 
        static int GetProduct(int[] productArray, int sum)
        {
            Console.WriteLine($"Please select a random number between 1 and {productArray.Length}");
            int randomNum = Convert.ToInt32(Console.ReadLine());
            int product = sum * randomNum;
            return product;
        }

        //static decimal GetQuotient(int num)
        //{ 
        //    Console.WriteLine($"Please enter a number to divide your product {num} by");
        //    int inputNum = Convert.ToInt32(Console.ReadLine());

        //}


    }
}
