using System;

namespace ParsingExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //The following two examples are the standard pattern for converting string to various number types.
            //However, if you entere a value which wasn't covertable to a int or a float, you would get an exception (an in your face error).
            //Experiment with these and see if you can get them to blow up. 

            //Parsing an integer and returning its squared value.
            Console.WriteLine("Enter an integer");
            string intInput = Console.ReadLine();
            int parsedInt = int.Parse(intInput);
            Console.WriteLine($"Your number squared is: {Math.Pow(parsedInt, 2)}");
            Console.WriteLine();
            //Parsing a double and returning it rounded to 2 decimals
            Console.WriteLine("Enter an number with more than 2 decimal places");
            string floatInput = Console.ReadLine();
            float parsedFloat = float.Parse(floatInput);
            Console.WriteLine($"Your number rounded to two decimal places is: {Math.Round(parsedFloat, 2)}");
            Console.WriteLine();



            //The following is a way to parse nicely. 
            //It is particularly useful for cases where user input is involved (ie. you aren't in control of what is being parsed)...
            Console.WriteLine("Enter an integer");
            string intInput2 = Console.ReadLine();
            if(int.TryParse(intInput2, out int parsedInt2))
            {
                Console.WriteLine($"Your number cubed is: {Math.Pow(parsedInt2, 3)}");
            }
            else
            {
                Console.WriteLine("Your input could not be converted to an integer.");
            }
            Console.ReadLine();
        }
    }
}
