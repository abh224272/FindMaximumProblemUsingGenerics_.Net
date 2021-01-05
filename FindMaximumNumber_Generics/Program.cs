﻿using System;

namespace FindMaximumNumber_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int intOutput = maximumNumberCheck.MaxIntegerNumber(10, 23, 43);
            Console.WriteLine(intOutput);
            float floatOutput = maximumNumberCheck.MaxFloatNumber(15.8f, 17.77f, 17.76f);
            Console.WriteLine(floatOutput);
        }
    }
}
