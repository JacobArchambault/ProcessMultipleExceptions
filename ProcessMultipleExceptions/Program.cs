﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);

            try
            {
                // Trip Arg out of range exception.
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                Console.WriteLine("Catching car is dead!");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
