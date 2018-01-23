/*
 * C# Program to Find Multiplication of two Binary Numbers
 */

using System;

namespace multiplication_of_two_binary_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            public static void Main()
            {

                int binary1, binary2, multiply = 0;
                int digit, factor = 1;
                prog pg = new prog();
                Console.WriteLine("Enter the first binary number: ");
                binary1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second binary number: ");
                binary2 = int.Parse(Console.ReadLine());
                while (binary2 != 0)
                {
                    digit = binary2 % 10;
                    if (digit == 1)
                    {
                        binary1 = binary1 * factor;
                        multiply = pg.binaryproduct(binary1, multiply);
                    }
                    else
                    {
                        binary1 = binary1 * factor;
                        binary2 = binary2 / 10;
                        factor = 10;
                    }
                    Console.WriteLine("Product of two binary numbers: {0}", multiply);
                    Console.ReadLine();
                }
            }


        }
    }
}
