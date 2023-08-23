using builder_pattern.@object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.builder
{
    public class CarBuilder : IBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        // Methods

        public void MakeAndModelSetter(String make, String model)
        {
            _car.Make = make;
            _car.Model = model;
        }
        
        public void BuildBody(String color)
        {
            _car.BodyColor = color;
        }

        public void PickEngine(String engine)
        {
            _car.Engine = engine;
        }

        public void AddWheels()
        {
            _car.Add("Front-Left Wheel");
            _car.Add("Front-Right Wheel");
            _car.Add("Rear-Left Wheel");
            _car.Add("Rear-Right Wheel");
        }

        public void AddPart(String part)
        {
            _car.Add(part);
        }

        public Vehicle GetVehicle()
        {
            return _car;
        }
    }
}
