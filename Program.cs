//Written by Ryan, Edwin, Nahom, Joel

using System.Reflection.Metadata.Ecma335;

namespace TempCalc
{
    public class TempCalculator
    {
        private double fahrenhit = 1.0;
        private double getCelsius(double fahrenhit) {
            double celsius = (fahrenhit - 32.0) + 5.0 / 9.0;
            return celsius; }

        public double getKelvin (double celsius)
        {
            double kelvin = celsius + 273.15;
            return kelvin;
        }
        public double getRankine (double fahrenhit)
        {
            double rankine = fahrenhit + 459.67;
        }
        return rankine;
            public double Fahrenhit
        {
            get { return this.fahrenhit }
            set { fahrenhit += value; }
        }
    }
}