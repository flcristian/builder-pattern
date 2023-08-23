using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.@object
{
    public class Car : Vehicle
    {
        // Constructors

        public Car(String make, String model, String bodyColor, String engine, List<String> parts) : base(make, model, bodyColor, engine, parts) { }

        public Car(String make, String model) : base(make, model, "default", "default", new List<String>()) { }

        public Car(String text)
        {
            String[] data = text.Split('/');

            Make = data[0];
            Model = data[1];
            BodyColor = data[2];
            Engine = data[3];
        }

        public Car() { }

        // Methods

        public override string ToString()
        {
            String desc = "Car\n";
            desc += $"Make : {Make}\n";
            desc += $"Model : {Model}\n";
            desc += $"Body Color : {BodyColor}\n";
            desc += $"Engine : {Engine}\n";
            desc += "Parts :\n";
            if(Parts.Count() > 0)
            {
                foreach (String part in Parts)
                {
                    desc += $"{part}\n";
                }
            }
            else
            {
                desc += "There are no parts.\n";
            }

            return desc;
        }
    }
}
