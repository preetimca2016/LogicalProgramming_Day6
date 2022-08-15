﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class ReverseNumber
    {
        public ReverseNumber()
        {
            Console.WriteLine("Enter the Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Reversed_Num = 0;
            string Digits = Convert.ToString(Number);

            for (int i = Digits.Length - 1; i >= 0; i--)
            {
                Reversed_Num += (Number % 10) * (int)Math.Pow(10, i);
                Number = Number / 10;
            }
            Console.WriteLine("This is Reversed Number" + Reversed_Num);
        }
    }
}
