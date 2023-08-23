using builder_pattern.builder;
using builder_pattern.@object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.director
{
    public class CarDirector : IDirector
    {
        public Vehicle Instruct(IBuilder builder)
        {
            Console.WriteLine("Enter the make :");
            String make = Console.ReadLine();
            Console.WriteLine("Enter the model :");
            String model = Console.ReadLine();
            builder.MakeAndModelSetter(make, model);

            Console.WriteLine("Enter the body color :");
            String bodyColor = Console.ReadLine();
            builder.BuildBody(bodyColor);

            Console.WriteLine("Pick an engine :");
            String engine = Console.ReadLine();
            builder.PickEngine(engine);

            builder.AddWheels();

            Console.WriteLine("Do you want to add another part? (Y/N)");
            String choice = Console.ReadLine();
            while (choice.ToLower().Equals("y"))
            {
                Console.WriteLine("Enter the part :");
                String part = Console.ReadLine();
                builder.AddPart(part);

                Console.WriteLine("Do you want to add another part? (Y/N)");
                choice = Console.ReadLine();
            }
            Console.WriteLine();

            return builder.GetVehicle();
        }
    }
}
