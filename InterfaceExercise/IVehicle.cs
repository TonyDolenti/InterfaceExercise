using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumOfWheels { get; set; }
        public int NumOfDoors { get; set; }
        public string EngineType { get; set; }
        public bool IsManual { get; set; }
        public bool HasChangedGears { get; set; }

        
        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);
        public void Details();
    }
}
