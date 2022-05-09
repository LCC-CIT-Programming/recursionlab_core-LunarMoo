using System;

namespace TowerOfHanoi
{
    class Program
    {
        //Using the Visual Studio Solution provided in the starting
        //files as a starting point, write a recursive method to solve
        //the Tower of Hanoi puzzle with n discs.  The method should
        //take an integer n representing the number of discs and a string
        //representing the name of the tower on which the discs start, a
        //string representing the name of the tower to which the discs must
        //be moved and a string representing the name of the extra tower as
        //its parameters.  The method does not return a value but displays
        //a message describing each move.  Use your method to write an
        //application that asks the user to enter how many discs they would
        //like and then displays the moves necessary to solve the puzzle.


        static void tower(int num, char source, char dest, char extra)
        {
            if (num == 0)
            {
                return;
            }
            tower(num - 1, source, extra, dest);
            Console.WriteLine("Move disk " + num + " from rod " +
                              source + " to rod " + dest);
            tower(num - 1, extra, dest, source);
        }
        static void Main(string[] args)
        {
            // Number of disks
            int num = 3; 
            // A, B and C are names of rods
            tower(num, 'A', 'C', 'B');  
        }
    }
}
