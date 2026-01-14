//This is how you make code comments

/*
This is 
a
multi-line comment
*/

//There are apprently how to do curly braces in C# to make things aesthetic

//Python uses snakecase
//C sharp uses something totally different. You just jam all the words together and use uppercase
// TinyTanks  This is 

using System;
namespace FirstNotes
{
    public class Program
    {
        public static void Main() //here you HAVE to have "main" as it's the way that C# works. It's similar to python def Main
        {
            //here's how to create a variable in C#
            int x = 5;
            //Or like this
            int y;
            y = 5;
            //Datatypes are int, double, string, bool, etc.
            Console.WriteLine(x + y);
            Console.WriteLine("The value of x is " + x);
            //This is how ot get an input from the user
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();
            Console.WriteLine(color);
        }
    }
}

//It seems like this is the typical structure for C# code

//There are at least two different types of errors. Compilation errors and rRuntime errors
