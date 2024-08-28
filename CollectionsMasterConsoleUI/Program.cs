using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseArray();
            
            
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Array
            //TODO: Create an integer Array of size 50

            int[] numbers = new int[50];
            Populater(numbers);
            List<int> numbersList = new List<int>();
            int i = 0;

            foreach (int number in numbers)
            {
                numbersList.Add(number);
                Console.WriteLine(number);
            }

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            
            
            

            //TODO: Print the first number of the array
            
            Console.WriteLine("Here is the first number on the List");
                Console.WriteLine($"{numbers[0]}");
            

            //TODO: Print the last number of the array 
            
            
            Console.WriteLine("Here  is the last number on the List");
            Console.WriteLine($"{numbers[numbers.Length-1]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            
            ReverseArray(numbers);
            

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"{numbersList.ToList().Capacity} is thr current");
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this
            Populater(numbers);
            

            //TODO: Print the new capacity
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            var wasParsedSuccess = int.TryParse(Console.ReadLine(), out int searchNumber);

            while (!wasParsedSuccess)
            {
                Console.WriteLine("that was not right. Pleas give a number");
                wasParsedSuccess = int.TryParse(Console.ReadLine(), out searchNumber);
                
            }
            NumberChecker(numbersList.ToList(), searchNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            
            
                Console.WriteLine(numbers);
            
            


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numbersList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numbersList.ToList().Sort();
            
            Console.WriteLine("------------------");
            NumberPrinter(numbers);

            //TODO: Convert the list to an array and store that into a variable
            var numbersListToArr = numbersList.ToArray();

            //TODO: Clear the list
            numbersList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"found{searchNumber}");
            }
            else
            {
                Console.WriteLine($"we didnt find searchNumber");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            while (numberList.Count <= 50)
            {
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
            
        }        

       private static void ReverseArray(int[] array)
        
        {
                
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
