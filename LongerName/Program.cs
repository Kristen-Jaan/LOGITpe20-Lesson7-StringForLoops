using System;
using System.Transactions;

namespace LongerName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("Enter the first name: ");
            string nameOne = Console.ReadLine();
            Console.WriteLine("Enter the second name: ");
            string nameTwo = Console.ReadLine();
            int lentghOne = 0;
            int lengthTwo = 0;
            foreach(char letter in nameOne)
            {
                lentghOne = lentghOne + 1;
            }
            foreach(char letter in nameTwo)
            {
                lengthTwo = lengthTwo + 1;
            }
            if(lentghOne > lengthTwo)
            {
                Console.WriteLine("Name One is the longest.");
            }
            else if(lentghOne < lengthTwo)
            {
                Console.WriteLine("Name Two is the longest.");
            }
            else
            {
                Console.WriteLine("Both names are the same lentgh.");
            }
            
            
        }
    }
}
