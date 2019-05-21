using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class LandTransport : Vehicle
    {
        private string typeLand; // категория техники (поезда, автомобили)

        public void SetTypeLand(string typeOfLandVehicle)
        {
            typeLand = typeOfLandVehicle;
        }
        public string GetTypeLandVehicle()
        {
            return typeLand;
        }

        public LandTransport() : base()  
        {
            typeLand = "Нет типа";
        }

        public LandTransport(string marka, uint speed, uint carrying, uint numOfStuff, uint numOfPassengers, string typeOfVehicle, string typeOfLandVehicle) 
            : base( marka, speed, carrying, numOfStuff, numOfPassengers, typeOfVehicle)  
        {
            typeLand = typeOfLandVehicle;
        }
        


    }
}
