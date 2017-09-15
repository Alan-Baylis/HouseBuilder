using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class HouseViewModel
    {
        private House House;

        public string Name
        {
            set { House.Name = value; }
            get { return House.Name; }
        }

        public int Stories
        {
            set { House.Stories = value; }
            get { return House.Stories; }
        }

        public bool Garage
        {
            set { House.Garage = value; }
            get { return House.Garage; }
        }

        public int Rooms
        {
            set { House.Rooms = value; }
            get { return House.Rooms; }
        }

        public bool Basement
        {
            set { House.Basement = value; }
            get { return House.Basement; }
        }

        public string GetKitchenTypeString()
        {
            return Enum.GetName(typeof(House.KitchenType), House.Kitchen);
        }

        public void setKitchen(House.KitchenType kitchen)
        {
            kitchen = House.Kitchen;
        }

        public string BathroomFlooring
        {
            set { House.BathroomFlooring = value; }
            get { return House.BathroomFlooring; }
        }

        public string BedroomFlooring
        {
            set { House.BedroomFlooring = value; }
            get { return House.BedroomFlooring; }
        }

        public string CommonAreaFlooring
        {
            set { House.CommonAreaFlooring = value; }
            get { return House.CommonAreaFlooring; }
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
                                                    .Append("Stories: {5}")
                                                    .Append(crlfs)
                                                    .Append("Garage: {2}")
                                                    .Append(crlfs)
                                                    .Append("Rooms: {4}")
                                                    .Append(crlfs)
                                                    .Append("Basement: {1}")
                                                    .Append(crlfs)
                                                    .Append("Kitchen: {3}")
                                                    .Append(crlfs)
                                                    .Append("Bathroom Flooring: {6}")
                                                    .Append(crlfs)
                                                    .Append("Bedroom Flooring: {7}")
                                                    .Append(crlfs)
                                                    .Append("Common Area Flooring: {8}")
                                                    .ToString();

            string[] houseTraits = { Name, Basement.ToString(), Garage.ToString(), GetKitchenTypeString(), Rooms.ToString(), Stories.ToString(), BathroomFlooring, BedroomFlooring, CommonAreaFlooring };
            String formattedHouse = String.Format(houseFormat, houseTraits);
            return formattedHouse;
        }

        public HouseViewModel()
        {
            this.House = new House();
        }
    }
}
