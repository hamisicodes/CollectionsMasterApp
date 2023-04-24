using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];
            

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);
            

            //TODO: Print the first number of the array
            Console.WriteLine("Printing the first number");
            Console.WriteLine(numbers[0]);
            Console.WriteLine("-------------------");


            //TODO: Print the last number of the array  
            Console.WriteLine("Printing the last number");
            Console.WriteLine(numbers[numbers.Length - 1]);       
            Console.WriteLine("-------------------");
  

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);


            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */

            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> numberList = new List<int>();
            

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"List capacity: {numberList.Capacity}");
                        

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);

            //TODO: Print the new capacity
            NumberPrinter(numberList);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int num;
            bool isParsed;

            do {
                Console.WriteLine("Please make sure its a number");
                isParsed = int.TryParse(Console.ReadLine(), out num);

            }
            while(isParsed == false);
            NumberChecker(numberList, num);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] numberArray = numberList.ToArray();

            //TODO: Clear the list
            Console.WriteLine("Clearing the list..");
            numberList.Clear();
            Console.WriteLine("Output after clearing...");
            NumberPrinter(numberList);


            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(var i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }

            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            foreach(var num in new List<int>(numberList)){
                if(num % 2 != 0)
                {
                    numberList.Remove(num);
                }
            }

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            var output = (numberList.Contains(searchNumber))? $"{searchNumber} is found in the list": $"{searchNumber} is NOT found in the list";
            Console.WriteLine(output);

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for(var i = 0; i < 50; i++)
            {
                var num = rng.Next(0,50);
                numberList.Add(num);
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for(var i = 0 ; i < 50; i++)
            {
                var num = rng.Next(0,50);
                numbers[i] = num;
            }


        }        

        private static void ReverseArray(int[] array)
        {
            var start = 0;
            var end = array.Length - 1;

            while(start <= end)
            {
                var temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start ++;
                end --;
            }
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