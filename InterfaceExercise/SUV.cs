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
        public string Name { get; set; } = "toyota";
        public string Motto { get; set; } = "lets go places";
        public int NumOfWheels { get; set; } = 4;
        public int NumOfDoors { get; set; } = 4;
        public string EngineType { get; set; } = "inline 6";
        public bool IsManual { get; set; } = false;
        public bool HasChangedGears { get; set; }

        public void Details()
        {
            Console.WriteLine($"This SUV is a {NumOfWheels} wheel, {NumOfDoors} door {Name} with {SeatRows} rows of seats.");
            Console.WriteLine($"Not to mention the powerful yet reliable and efficient {EngineType}, but it's manual? {IsManual}");
            Console.WriteLine($"You must be thinking for such a great price it has all wheel drive too? {AllWeelDrive}.");
        }
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
