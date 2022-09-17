using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt user to ask how many numbers they will enter to build the size of the array
            Console.WriteLine("How many numbers in total: ");
            string numCountStr = Console.ReadLine();
            int numCount = Convert.ToInt32(numCountStr);
            int[] userNum = new int[numCount];

            // create the loop of asking the user for numbers limited to the array sSize
            for (int i = 0; i < numCount; i++)
            {
                Console.WriteLine($"Please enter number for entry {i + 1} : ");
                string num_Str = Console.ReadLine();
                int number = Convert.ToInt32(num_Str);
                if (number > 100000 || number < -100000)
                {
                    //Handles invalid entries
                    Console.WriteLine("Invalid entry. Please try again");
                    --i;
                    continue;
                }
                userNum[i] = number;
            }

            Console.WriteLine();
            // create loop to display all numbers for each entry
            for (int i = 0; i < userNum.Length; ++i)
                Console.WriteLine($"Your number for entry {i + 1} is {userNum[i]}");



        }
    }
}
