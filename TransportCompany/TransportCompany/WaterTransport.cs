using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class WaterTransport : Vehicle
    {
        private string typeWater; // категория техники (лайнеры, корабли)

        public void SetTypeWater(string typeOfWaterVehicle)
        {
            typeWater = typeOfWaterVehicle;
        }
        public string GetTypeWaterVehicle()
        {
            return typeWater;
        }

        public WaterTransport() : base()
        {
            typeWater = "Нет типа";
        }

        public WaterTransport(string marka, int speed, int carrying, int numOfStuff, int numOfPassengers, string typeOfVehicle, string typeOfWaterVehicle)
            : base(marka, speed, carrying, numOfStuff, numOfPassengers, typeOfVehicle)
        {
            typeWater = typeOfWaterVehicle;
        }
    }
}
