using System;

namespace CodeKatas
{
    class Program
    {
        
        static void Main(string[] args)
        {

            void CalculateFibonacci()
            {
                double Number1 = 1;
                double Number2 = 2;
                double MaxNumber = 4000000;
                double CurrentEvenTotal = 2;

                while (Number2 <= MaxNumber)
                {
                    double CurrentNumber = (Number1 + Number2);

                    if ((CurrentNumber) % 2 == 0)
                    {
                        Console.WriteLine(CurrentNumber);
                        CurrentEvenTotal += CurrentNumber;
                        Number1 = Number2;
                        Number2 = CurrentNumber;
                    }
                    else
                    {
                        Number1 = Number2;
                        Number2 = CurrentNumber;
                    }
                }
                Console.WriteLine("The sum of all even Fibonacci Numbers less than 4,000,000 is " + CurrentEvenTotal);
            }
            CalculateFibonacci();

        }
    }
}
