using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name: Dongyun Huang 
/// ID: 30042104
/// The DLL project file contains four mathematical formulas
/// </summary>
namespace AstroMath
{
    /// <summary>
    /// The class has four mathematical formulas methods
    /// ID string generated is "T:AstroMath.Formulas".
    /// </summary>
    public class Formulas
    {
        /// <summary>
        /// The method is used for measuring the Star velocity using the Doppler shift
        /// ID string generated is "M:AstroMath.Formulas.StarVelocit(System.Double,System.Double)".
        /// <param name="observedWavelength">A input parameters of type double (Observed Wavelength).</param>
        /// <param name="restWavelength">A input parameters of type double (Rest Wavelength).</param>
        /// <returns>A double which represents the velocity.</returns>
        public double StarVelocity(double observedWavelength, double restWavelength)
        {
            if (restWavelength != 0)
            {
                double velocity = 299792458 * (observedWavelength - restWavelength) / restWavelength;
                return Math.Round(velocity, 4);
            }
            else { return 0.00001; }
        }
        /// <summary>
        /// The method is used for measuring the star distance using the parallax angle.
        /// ID string generated is "M:AstroMath.Formulas.StarVelocit(System.Double)".
        /// <param name="arcsecondsAngle">A input parameters of type double (Arcseconds angle).</param>
        /// <returns>A double which is a value in parsecs.</returns>
        public double StarDistance(double arcsecondsAngle)
        {
            if (arcsecondsAngle != 0)
            {
                return Math.Round(1 / arcsecondsAngle, 4);
            }
            else { return 0.00001; }
        }
        /// <summary>
        /// The method is used for converting temperature from celsius to kevine.
        /// ID string generated is "M:AstroMath.Formulas.StarVelocit(System.Double)".
        /// <param name="celsius">A input parameters of type double (Celsius).</param>
        /// <returns>A double which is the temperature in degrees kelvin.</returns>
        public double TemperatureConversion(double celsius)
        {
            if (celsius > -273)
            {
                return celsius + 273;
            }
            else { return 0.00001; }
        }
        /// <summary>
        /// The method is used for measuring the distance from the centre of a blackhole to the event horizon..
        /// ID string generated is "M:AstroMath.Formulas.StarVelocit(System.Double)".
        /// <param name="blackHoleMass">A input parameters of type double (Blackhole Mass).</param>
        /// <returns>A double which is the event horizon in metres (Schwarzschild radius (R)).</returns>
        public double BlackholeEventHorizon(double massBase, double massExponent)
        {
            const double GravityConstant = 6.674e-11;  // m^3 kg^-1 s^-2
            const double SpeedOfLight = 299792458.0;   // m/s
            double blackHoleMass = massBase * Math.Pow(10, massExponent);

            if (Math.Pow(SpeedOfLight, 2) != 0)
            {
                // Calculate the Schwarzschild radius (R) in meters
                double schwarzschildRadius = (2.0 * GravityConstant * blackHoleMass) / Math.Pow(SpeedOfLight, 2);
                return Math.Round(schwarzschildRadius, 4);
            }
            else { return 0.00001; }
        }
    }
}
