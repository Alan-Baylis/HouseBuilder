using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        public string name;
        public string stories;
        public string basement;
        public int rooms;
        public string garage;
        public string kitchen;
        public string bathroomFlooring;
        public string bedroomFlooring;
        public string commonAreaFlooring;

        public override string ToString()
        {
            return GetFormattedHouse();
        }

        private string GetFormattedHouse()
        {
            string crlfs = "\r\n\r\n";
            string houseFormat = new StringBuilder().Append("Name: {0}")
                                                    .Append(crlfs)
                                                    .Append("Basement: {1}")
                                                    .Append(crlfs)
                                                    .Append("Garage: {2}")
                                                    .Append(crlfs)
                                                    .Append("Kitchen: {3}")
                                                    .Append(crlfs)
                                                    .Append("Rooms: {4}")
                                                    .Append(crlfs)
                                                    .Append("Stories: {5}")
                                                    .Append(crlfs)
                                                    .Append("Bathroom Flooring: {6}")
                                                    .Append(crlfs)
                                                    .Append("Bedroom Flooring: {7}")
                                                    .Append(crlfs)
                                                    .Append("Common Area Flooring: {8}")
                                                    .ToString();
                                                    
            string[] houseTraits = { name, basement, garage, kitchen, rooms.ToString(), stories, bathroomFlooring, bedroomFlooring, commonAreaFlooring };
            String formattedHouse = String.Format(houseFormat, houseTraits);
            return formattedHouse;
        }
    }
}
