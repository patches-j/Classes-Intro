//----------------------------------------------------
// Copyright 2020 Epic Systems Corporation
//----------------------------------------------------

using Cars.Ford;
using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a new instance of Ford");
            FordBase ford = new FordBase(23.2, 8.6);
            Console.WriteLine("Add 23.2 gallons of fuel");
            ford.AddFuel(23.2);
            Console.WriteLine("Drive 100 miles");
            ford.Drive(100);
            Console.WriteLine(string.Format("Remaining Fuel: {0} gallons", ford.RemainingFuel));
            Console.ReadKey();
        }
    }
}
