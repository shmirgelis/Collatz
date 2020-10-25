using System;

namespace Collatz
{
    class Collatz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter positive integer");
            string givenNumber = Console.ReadLine();
            uint number = uint.Parse(givenNumber); //using uint integer type to calculate 837799, int type range is too short
            uint i = 0;
            while(number > 1)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = number * 3 + 1;
                }
                Console.WriteLine(number);
                i++;
            }
            Console.WriteLine("It took " + i + " steps");
        }
    }
}
