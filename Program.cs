using System;
using System.Linq;


namespace My_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * You can store multiple variables of the same type in an array data structure
             * You declare an array by specifying the type of its elements
             * The variables in the array are ordered, and each has an index beginning with 0
             * C# array is an object of base type System.Array
            */
            // Declare a single-dimensional array of 5 integers
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[5] { 6, 7, 8, 9, 10 };
            
            // Create an array of 4 elements, and add values later
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);

            //Update the value of a specific element
            cars[0] = "Kia";
            Console.WriteLine(cars[0]);

            // Declare and set array element values.
            int[,,] multiDimensionalArray = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 1, 2, 3 }, { 4, 5, 6 } } };
            multiDimensionalArray[0, 0, 0] = 5;
            Console.WriteLine (multiDimensionalArray[1, 1, 2]);

            //Properties
            int len = numbers.Length;
            int Dim = multiDimensionalArray.Rank;
            Console.WriteLine("numbers length is: " + len.ToString());
            Console.WriteLine("multidimensionalArray dimensions are: " + Dim.ToString());

            // Loop Through an Array
            Console.WriteLine("For Loop");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //There is also a foreach loop, which is used exclusively to loop through elements in an array
            Console.WriteLine("Foreach");

            foreach (string element in cars) 
            {
                Console.WriteLine(element); 
            }

            int idx = 0;
            foreach (int number in numbers)
            {
                numbers[idx] = 2 * number + 1;
                Console.WriteLine(numbers[idx]);
                idx++;
            }

            // Sorting
            //Sort a array
            Console.WriteLine("");
            Console.WriteLine("Sorting");
            int[] myNumbers = { 5, 2, 8, 9};
                        
            foreach (int number in myNumbers)
            {
                Console.WriteLine(number);
            }

            //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace
            Console.WriteLine("The max value in myNumbers is " + myNumbers.Max(). ToString()); // returns the largest value
            Console.WriteLine("The sum value in myNumbers is " + myNumbers.Sum().ToString());
            
        }
    }
}