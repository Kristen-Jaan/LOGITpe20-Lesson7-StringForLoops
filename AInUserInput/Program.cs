using System;
using System.Transactions;

namespace AInUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("Enter your name");
            string userInput = Console.ReadLine();
            char searchCriteria = 'a';
            int counter = 0;

            foreach(char letter in userInput)
            {
                if(letter == searchCriteria)
                {
                    counter = counter + 1;
                }
                
                
            }
            if(counter > 0)
            {
                Console.WriteLine($"There are {counter} As in your name.");
            }
            else
            {
                Console.WriteLine("There are no As in your name.");
            }
            
            
                
            
                
            
                
            
            
        }
    }
}
