using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int reverse;
            int largestPalindrome = 0;
            int product;
            

            for (int numOne = 100; numOne < 1000; numOne++)
            {


                for (int numTwo = 100; numTwo < 1000; numTwo++)
                {
                    product = numOne * numTwo;

                    reverse  = ReverseNumber(product);

                    //If the product is a palindrome...
                    if (product == reverse)
                    {
                        //if that palindrome is larger than the largest palindrome..
                        if (product > largestPalindrome)
                        {
                            //Store the product as the new largest palindrome.
                            largestPalindrome = product;

                        }
                    }

                }
            }

            Console.WriteLine("the largest palindrome is {0}", largestPalindrome);
            Console.ReadLine();


        }

        static int ReverseNumber(int loopnumber)
        {
            int number = loopnumber;
            int reverse = 0;
            int remainder = 0;


            while (number > 0)
            {
                remainder = number % 10; //remainder is the last digit of number.

                reverse = (reverse * 10) + remainder; //by multiplying reverse by ten, we move all of the digits of reverse over and make room in the ones place for remainder.

                number = number / 10; //Removes the last digit of number
            }

            return reverse;
        }
    
    }
}
