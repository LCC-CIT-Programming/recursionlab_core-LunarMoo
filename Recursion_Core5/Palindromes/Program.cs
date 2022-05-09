using System;

namespace Palindromes
{
    class Program
    {
        //Using the Visual Studio Solution provided in the starting files as a
        //starting point, write a recursive method to determine if a string is a
        //palindrome.  The method should take a string s as its parameter and
        //return a bool. Use your method to write an application that asks the
        //user to enter a word or phrase from the keyboard and then tells the
        //user whether or not the text that they entered is a palindrome.
        //Capitalization whitespace and punctuation should be removed before
        //calling your function.

        //A palindrome is a word, number, phrase, or other sequence of
        //characters which reads the same backward as forward, such as madam,
        //racecar.



        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
        static void Main(string[] args)
        {
            Console.Write(" Recursion : Check whether a string ia Palindrome or not :");

            string str1;
            bool tf;

            Console.Write(" Input a string : ");
            str1 = Console.ReadLine();
            tf = IsPalindrome(str1);
            if (tf == true)
            {
                Console.WriteLine(" The string is Palindrome.\n");
            }
            else
            {
                Console.WriteLine(" The string is not a Palindrome.\n");
            }
        }
    }
}
