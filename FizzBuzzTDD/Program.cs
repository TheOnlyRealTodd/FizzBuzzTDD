using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzClasses;

namespace FizzBuzzTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }
        }
    }
    
}
