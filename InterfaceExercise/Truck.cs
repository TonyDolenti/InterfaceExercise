using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle ,  ICompany
    {
        public Truck()
        {

        }
        public bool HasExtendedCab { get; set; } = true;
        public bool HasExtendedBed { get; set; } = true;
        public string Name { get; set; } = "F-150";
        public string Motto { get; set; } = "Found On the Roadside Dead";
        public int NumOfWheels { get; set; } = 4;
        public int NumOfDoors { get; set; } = 4;
        public string EngineType { get; set; } = "V8";
        public bool IsManual { get; set; } = false;
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving.");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving in reverse");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now parked");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot put in park until we change gears");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
        public void Details()
        {
            Console.WriteLine($"This Truck is a {NumOfWheels} wheel, {NumOfDoors} door {Name} with an extended cab? {HasExtendedCab}.");
            Console.WriteLine($"Not to mention the powerful yet reliable and efficient {EngineType} engine, but it's manual? {IsManual}");
            Console.WriteLine($"You must be thinking for such a great price it has an extended bed too? {HasExtendedBed}");
            Console.WriteLine($"Come on down to Ford,{Motto}.");
        }
    }
}
