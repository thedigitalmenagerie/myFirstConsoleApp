using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Honey-Rae";

            // specificity around numbers

            // 32 bit signed number
            int favoriteNumber = 2147483647;
            // 64 bit signed number
            long reallyBigNumber = 9223372036854775807;
            // 16 bit integer 
            short smallerNumber = 32767;
            // u attached to each of the above means unsigned or positive only

            double accountBalance = 0.57;
            // more precise than double
            decimal accountBalance2 = 0.57M;

            // type inference -- language infers what type it is when you do not specify and you still can't
            // change it due to static type rule
            var myStuff = 5 * 5;

            // lists
            // <> these are angle brackets to specify the genereic type
            // a list of string || a list of type string
            // new keyword instantiation // instance of a kind of thing and will require you call the construction with parenthesis
            var students = new List<string>();
            // adds to end
            students.Add("Lindsey");
            students.Add("Casey");
            students.Add("Tad");
            students.Add("Jimbo");
            // removes
            students.Remove("Jimbo");

            // put something in the console to be interacted with 

            // iterate over the student and print them out to the console
            for (var = 0; i < students.Count; i ++)
                {
                Console.WriteLine(students[i]);
            }
        }
    }
}
