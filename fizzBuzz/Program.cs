using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to  set fizz, buzz and highest number to count to seperated by a space"); //ask for data from user
            string userInput = Console.ReadLine(); //get user from data
            string[] myvals = userInput.Split(' '); //seperate data from string based on ' '

            int fizz = Convert.ToInt32(myvals[0]);
            int buzz = Convert.ToInt32(myvals[1]);
            int num = Convert.ToInt32(myvals[2]);
          
            for (int counter= 1; counter < num; counter++) //loop and print numbers on same line until iterator equals numLimit
            {
                if (counter % fizz == 0 && counter % buzz == 0) //if number is equal to both fizz and buzz
                {
                    Console.WriteLine("FB"); //print FB
                }
                else if (counter % buzz == 0) //if number is equal to buzz
                {
                    Console.WriteLine("B"); //print B
                }
                else if (counter % fizz == 0) //if number is equal to fizz
                {
                    Console.WriteLine("F"); //print F
                }
                else
                {
                    Console.WriteLine(counter); //print number
                }
            }
        }
    }
}
