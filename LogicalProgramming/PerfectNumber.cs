using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class PerfectNumber
    {
        public bool Factors(int Number, int potential_Factor)  //Parameterised method
        {
        if(Number % potential_Factor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public PerfectNumber()
        {
            int check = 0;
            Console.WriteLine("Enter the Number");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Number / 2; i++)
            {
                if (Factors(Number, i))
                {
                    check += i;
                }
            }
            if(check == Number)
            {
                Console.WriteLine("Number is perfect Number");
            }
                else
                {
                    Console.WriteLine("Number is not perfect Number");
                }
            }
        
    }
}
