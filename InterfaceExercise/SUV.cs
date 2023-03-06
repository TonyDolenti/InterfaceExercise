using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle , ICompany
    {
        public SUV() 
        { 
        }
        public int SeatRows { get; set; } = 3;
        public bool AllWeelDrive { get; set; } = true;
        string ICompany.Name { get; set; } = "toyota";
        string ICompany.Motto { get; set; } = "lets go places";
        int IVehicle.NumOfWheels { get; set; } = 4;
        int IVehicle.NumOfDoors { get; set; } = 4;
        string IVehicle.EngineType { get; set; } = "inline 6";
        bool IVehicle.IsManual { get; set; } = false;
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
