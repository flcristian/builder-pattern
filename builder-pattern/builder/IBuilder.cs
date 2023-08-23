using builder_pattern.@object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.builder
{
    public interface IBuilder
    {
        void MakeAndModelSetter(String make, String model);

        void BuildBody(String color);

        void PickEngine(String engine);

        void AddWheels();

        void AddPart(String part);

        Vehicle GetVehicle();
    }
}
