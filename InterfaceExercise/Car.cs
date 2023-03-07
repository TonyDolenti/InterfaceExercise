using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle , ICompany
    {
        public Car() 
        {
        }
        public int NumOfSeats { get; set; } = 4;
        public bool SeparateTrunk { get; set; } = true;
        public string Name { get; set; } = "accord";
        public string Motto { get; set; } = "the power of dreams";
        public int NumOfWheels { get; set; } = 4;
        public int NumOfDoors { get; set; } = 2;
        public string EngineType { get; set; } = "i4";
        public bool IsManual { get; set; } = true;
        public bool HasChangedGears { get; set; }

        
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving.");
        }

        public void Reverse()
        {
            if(HasChangedGears == true)
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
            Console.WriteLine($"This Car is a {NumOfSeats} seat,{NumOfDoors} door,{EngineType}, Honda {Name}.");
            Console.WriteLine($"The {Name} has a separate trunk?{SeparateTrunk}, but it's manual? {IsManual}");
            Console.WriteLine($"For such a great price and reliability, this {NumOfWheels} wheel, compact sedan is just right for you.");
            Console.WriteLine($"Come down to Honda,{Motto}.");
        }
    }
}
