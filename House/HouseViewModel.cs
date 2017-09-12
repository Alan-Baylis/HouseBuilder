using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class HouseViewModel
    {
        public House House;

        public string Name
        {
            set { House.name = value; }
            get { return House.name; }
        }

        public string Stories
        {
            set { House.stories = value; }
            get { return House.stories; }
        }

        public string Basement
        {
            set { House.basement = value; }
            get { return House.basement; }
        }

        public string Garage
        {
            set { House.garage = value; }
            get { return House.garage; }
        }

        public string Kitchen
        {
            set { House.kitchen = value; }
            get { return House.kitchen; }
        }

        public int Rooms
        {
            set { House.rooms = value; }
            get { return House.rooms; }
        }

        public string BathroomFlooring
        {
            set { House.bathroomFlooring = value; }
            get { return House.bathroomFlooring; }
        }

        public string BedroomFlooring
        {
            set { House.bedroomFlooring = value; }
            get { return House.bedroomFlooring; }
        }

        public string CommonAreaFlooring
        {
            set { House.commonAreaFlooring = value; }
            get { return House.commonAreaFlooring; }
        }

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

            string[] houseTraits = { Name, Basement, Garage, Kitchen, Rooms.ToString(), Stories, BathroomFlooring, BedroomFlooring, CommonAreaFlooring };
            String formattedHouse = String.Format(houseFormat, houseTraits);
            return formattedHouse;
        }

        public HouseViewModel()
        {
            this.House = new House();
        }
    }
}
