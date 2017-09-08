using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class (HouseBuilder) is no longer in use after refactoring in HouseViewModelBuilder
namespace House
{
    public class HouseBuilder
    {
        House house;

        public HouseBuilder()
        {
            house = new House();
        }

        public HouseBuilder setName(string name)
        {
            house.name = name;
            return this;
        }

        public HouseBuilder setStories(string stories)
        {
            house.stories = stories;
            return this;
        }

        public HouseBuilder setGarage(string garage)
        {
            house.garage = garage;
            return this;
        }
        
        public HouseBuilder setRooms(int rooms)
        {
            house.rooms = rooms;
            return this;
        }
        
        public HouseBuilder setBasement(string basement)
        {
            house.basement = basement;
            return this;
        }

        public HouseBuilder setkitchen(string kitchen)
        {
            house.kitchen = kitchen;
            return this;
        }

        public HouseBuilder setBathroomFlooring(string bathroomFlooring)
        {
            house.bathroomFlooring = bathroomFlooring;
            return this;
        }

        public HouseBuilder setBedroomFlooring(string bedroomFlooring)
        {
            house.bedroomFlooring = bedroomFlooring;
            return this;
        }

        public HouseBuilder setCommonAreaFlooring(string commonAreaFlooring)
        {
            house.commonAreaFlooring = commonAreaFlooring;
            return this;
        }

        public House Build()
        {
            return house;
        }
    }
}
