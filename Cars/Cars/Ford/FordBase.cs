//----------------------------------------------------
// Copyright 2020 Epic Systems Corporation
//----------------------------------------------------


using Cars.Base_Classes;

namespace Cars.Ford
{
    /// <summary>
    /// This class now inherits all the properties and methods from CarBase.
    /// </summary>
    public class FordBase : CarBase
    {
        /// <summary>
        /// We have a constructor for FordBase. If we use : base() we can then call the constructor from the base
        /// class and it will run that code, so we don't have to write it again!
        /// </summary>
        /// <param name="fuelTankSize">The size of the fuel tank</param>
        /// <param name="MPG">Fuel Economy of the car</param>
        public FordBase(double fuelTankSize, double MPG) : base(fuelTankSize, MPG) { }

        /// <summary>
        /// This is a property we are defining that can never be set. Every time it's reference, it will simply return "Ford"
        /// </summary>
        public string Brand { get => "Ford"; }
    }
}
