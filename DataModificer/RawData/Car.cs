using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        

        public Car(Tires[] tires, Cargo cargo, Engine engine,string model)
        {
            this.Tires = tires;
            this.Cargo = cargo;
            this.Engine = engine;
            this.Model = model;

        }

        public Tires[] Tires { get; set; }

        public Cargo Cargo { get; set; }

        public Engine Engine { get; set; }

        public string Model { get; set; }
        public string Where { get; internal set; }
    }
}
