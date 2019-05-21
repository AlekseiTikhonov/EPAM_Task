using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class AirTransport : Vehicle
    {
        private string typeAir; // категория техники (самолёты, вертолёты)

        public void SetTypeAir(string typeOfAirVehicle)
        {
            typeAir = typeOfAirVehicle;
        }
        public string GetTypeAirVehicle()
        {
            return typeAir;
        }

        public AirTransport() : base()
        {
            typeAir = "Нет типа";
        }

        public AirTransport(string marka, uint speed, uint carrying, uint numOfStuff, uint numOfPassengers, string typeOfVehicle, string typeOfAirVehicle)
            : base(marka, speed, carrying, numOfStuff, numOfPassengers, typeOfVehicle)
        {
            typeAir = typeOfAirVehicle;
        }
    }
}
