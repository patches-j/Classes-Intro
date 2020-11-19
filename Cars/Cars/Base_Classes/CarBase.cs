//----------------------------------------------------
// Copyright 2020 Epic Systems Corporation
//----------------------------------------------------


namespace Cars.Base_Classes
{
    /// <summary>
    /// This class stores all of the properties and methods that apply to all
    /// cars. For example, all [gas] cars have a fuel tank, and miles per gallon. 
    /// You can also drive all the cars which consumes fuel. Putting them in a base class
    /// means we only have to write the code once.
    /// </summary>
    public class CarBase
    {
        /// <summary>
        /// Functions that have the same name as the class name are called constructors. They create 
        /// a new instance of this class. 
        /// </summary>
        public CarBase() { }

        /// <summary>
        /// Constructors can take in parameters to initialize values in the class
        /// </summary>
        /// <param name="fuelTankSize">The size of the fuel tank</param>
        /// <param name="MPG">Fuel Economy of the car</param>
        public CarBase(double fuelTankSize, double MPG)
        {
            FuelTankSize = fuelTankSize;
            FuelEconomy = MPG;
        }

        #region Public Properties
        /// <summary>
        /// Remaining fuel is public for getting the data, but private for setting
        /// the data. In order to add fuel or substract fuel we want you to call a function.
        /// If they were both public, then someone could just call Car.RemainingFuel = <number>
        /// </summary>
        public double RemainingFuel { get; private set; }

        /// <summary>
        /// Similarly here, we only want to set this value from within this class. But outside code
        /// can read this value
        /// </summary>
        public double FuelTankSize { get; private set; }

        /// <summary>
        /// Fuel Economy of the vehicle
        /// </summary>
        public double FuelEconomy { get; private set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// This method allows callers to add fuel to the tank, which any outside caller can do
        /// </summary>
        /// <param name="numberOfGallons">The number of gallons the user is trying to add</param>
        /// <returns>True if the fuel was successfully added. False if the numberOfGallons was too large</returns>
        public bool AddFuel(double numberOfGallons)
        {
            if (RemainingFuel + numberOfGallons > FuelTankSize)
            {
                // Validate that we have adequate space
                return false;
            }
            RemainingFuel += numberOfGallons;
            return true;
        }

        /// <summary>
        /// This method allows callers to drive the car a number of miles. 
        /// </summary>
        /// <param name="miles">How far to drive</param>
        /// <returns>True if we could drive that far</returns>
        public bool Drive(double miles)
        {
            double requiredFuel = CalculateFuelNeeded(miles);
            if (requiredFuel > RemainingFuel)
            {
                return false;
            }
            RemainingFuel -= requiredFuel;
            return true;
        }


        #endregion

        #region Private Methods
        /// <summary>
        /// Private members can only be used within this class. So if we didn't want outside code/callers
        /// to caclulate this value we would mark it as private
        /// </summary>
        /// <param name="miles">How many miles we want to drive</param>
        /// <returns>The number of gallons of fuel needed</returns>
        private double CalculateFuelNeeded(double miles)
        {
            return miles / FuelEconomy;
        }
        #endregion
    }
}
