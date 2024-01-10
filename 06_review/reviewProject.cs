// Amarion Burks, Review Project, v0.0
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {
            // Declaring Variables

            // Integer: -2,147,483,268 to 2,147,483,267
            // 4 Bytes
            int number = 0;

            // Long: -9,223,372,036,772,808 to -9,223,372,036,772,807
            // 8 Bytes
            long Long = 5489578354;

            // Float: Stores up to 6-7 decimal digits
            // 4 Bytes
            float floaty = 0.55F;

            // Double: Up to 15 decimal digits
            // 8 Bytes
            double doubley = 0.49350283745D;

            // Boolean: True / False
            // 1 Bit
            bool checking = false;

            // String
            // 2 Bytes PER CHARACTER
            string text = "funny string";

            // Character (char)
            // Single character, SINGLE QUOTES ' '
            // 2 Bytes
            char charChar = 'F';

            // Type Casting: changing one data type to another
            // IMPLICIT: happens auto when going smaller to larger
            // char -> int -> long -> float -> double

            int funnyInt = 9;
            double myDouble = funnyInt;
            Console.WriteLine(myDouble);

            // EXPLICIT: Must be done manually when going larger to smaller
            // double -> float -> long -> int -> char
            double doubleTwo = 5.543467834656D;
            int intTwo = (int) doubleTwo;
            Console.WriteLine(doubleTwo);
            Console.WriteLine(intTwo);

            // Conversion Methods
            Convert.ToString(funnyInt);
            Convert.ToDouble(number);
            Convert.ToInt32(doubleTwo); //int
            Convert.ToInt64(myDouble); //long

            Console.WriteLine(funnyInt);
            Console.WriteLine(number);
            Console.WriteLine(doubleTwo);
            Console.WriteLine(myDouble);

            // Switch Statement
            int dayOfWeek = 5;
            switch (dayOfWeek)
            {
                default:
                    Console.WriteLine("No match found\n");
                    break;
                case 1:
                    Console.WriteLine("The day is Sunday.\n");
                    break;
                case 2:
                    Console.WriteLine("The day is Monday\n");
                    break;
                case 3:
                    Console.WriteLine("The day is Tuesday\n");
                    break;
                case 4:
                    Console.WriteLine("The day is Wednesday\n");
                    break;
                case 5:
                    Console.WriteLine("The day is Thursday\n");
                    break;
                case 6:
                    Console.WriteLine("The day is Friday\n");
                    break;
                case 7:
                    Console.WriteLine("The day is Saturday\n");
                    break;
                

            }

        }
    }
}