using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class House
    {
        public string Name;
        public int Stories;
        public bool Garage;
        public int Rooms;
        public bool Basement;
        public string BathroomFlooring;
        public string BedroomFlooring;
        public string CommonAreaFlooring;
        public KitchenType Kitchen;
        public enum KitchenType
        {
            Regular = 0, Gormet = 1
        }
    }
}
