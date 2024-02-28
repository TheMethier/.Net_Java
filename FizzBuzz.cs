﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKZad1
{
    internal class FizzBuzz
    {
        public int UpperBound { get; set; }
        public FizzBuzz(int upperBound)
        {
            UpperBound = upperBound;
        }
        public void Display()
        {
            for(int i = 1; i <= UpperBound; i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
               
            }
        }
    }
}
