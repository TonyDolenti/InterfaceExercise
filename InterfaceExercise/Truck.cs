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
    }
}
