using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tires
    {
        public Tires(int tireAge, double tirePressure)
        {
            this.tireAge = tireAge;
            this.tirePressure = tirePressure;
        }

        public int tireAge { get; set; }

        public double tirePressure { get; set; }






        // "{model}
        //{tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
    }
}
