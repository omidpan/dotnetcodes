using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parameters are passed by value by default.
            int number = 20;
            AddFive(number);
            Console.WriteLine("After AddFive, number is still: " + number);


            // Use 'ref' keyword to pass by reference.
            AddFiveRef(ref number);
            Console.WriteLine("After AddFiveRef with ref, number is now: " + number);


            //out Modifier
            int addedValue, subtractedValue;// we can declare variables without initializing them and modify them inside the method
            DoMath(10, 5, out addedValue, out subtractedValue);
            Console.WriteLine(addedValue);
            Console.WriteLine(subtractedValue);


            //in Modifier. we cannot modify the value of the parameter inside the method
            string aVeryLargeString = "This is a very large string that we don't want to be copied.";
            inMethod(in aVeryLargeString);


            //optional parameters
            int sum1 = OptionalParameters(1, 2); // optionalParam uses default value 0
            Console.WriteLine(sum1);
            int sum2 = OptionalParameters(1, 2, 3); // optionalParam is explicitly set to 3
            Console.WriteLine(sum2);


            //named parameters
            //Traditional method call-in order
            PrintUserDetails(userId: 101, name: "Alice", 42, null);
            ;//Named parameters, can be in any order, optional parameters can be omitted
            PrintUserDetails(name: "Bob", userId: 102);
            //Named parameters in any order
            PrintUserDetails(addressLines: new List<string> { }, userId: 103, name: "Charlie", age: 30);

            //params Modifier(keyword)
            UseParams(1, 2, 3, 4);

            UserParamsWithObjects(1, "a", "test");

        }
        private static void AddFive(int number)
        {

            number += 5;
           
        }
        private static void AddFiveRef(ref int number)
        {
            number += 5;
        }

        //out Modifier
        private static void DoMath(int number1, int number2, out int addedValue, out int subtractedValue)
        {
            addedValue = number1 + number2;
            subtractedValue = number1 - number2;

        }

        //in Modifier
        private static void inMethod(in string largeString)
        {
            Console.WriteLine(largeString);
            //largeString += "Trying to modify"; // This would cause a compile-time error.
        }

        //optional parameters
        private static int OptionalParameters(int requiredParam1, int requiredParam2, int optionalParam = 0)
        {
            return requiredParam1 + requiredParam2 + optionalParam;
        }

        //named parameters
        public static void PrintUserDetails(int userId, string name, int age = -1, List<string> addressLines = null)
        {
            // Print details...
            Console.WriteLine($"UserID: {userId}, Name: {name}, Age: {age} years old...");
        }

        //params Modifier(keyword)
        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public static void UserParamsWithObjects(params object[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }


    }
}
