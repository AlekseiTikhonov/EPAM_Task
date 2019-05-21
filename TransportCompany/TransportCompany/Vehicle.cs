using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Vehicle
    {
        private string mark; //марка
        private string type; // тип техники (наземная, воздушная, водная)
        private uint maxSpeed; // максимальная скорость
        private uint capacity; // грузоподъемность
        private uint stuff; // количество персонала
        private uint passengers; // количество пассажиров
        
        public void SetMark(string marka)
        { 
            mark = marka; 
        }
        public void SetType(string typeOfVehicle)
        {
            type = typeOfVehicle;
        }
        public void SetMaxSpeed(uint speed)
        { 
            maxSpeed = speed; 
        }
        public void SetCapacity(uint carrying)
        {
            capacity = carrying;
        }
        public void SetStuff(uint numOfStuff)
        {
            stuff = numOfStuff;
        }
        public void SetPassengers(uint numOfPassengers)
        {
            passengers = numOfPassengers;
        }

        public uint GetMaxSpeed()
        { 
          return maxSpeed; 
        }
        public string GetMark()
        { 
            return mark; 
        }
        public string GetTypeOfVehicle()
        {
            return type;
        }

        public uint GetCapacity()
        {
            return capacity;
        }
        public uint GetStuff()
        {
            return stuff;
        }
        public uint GetPassengers()
        {
            return passengers;
        }
        public Vehicle()
        { // конструктор класса (без параметров)
            mark = "Без названия";
            maxSpeed = 0;
            capacity = 0;
            stuff = 0;
            passengers = 0;
            type = "Нет типа";
        }
        public Vehicle(string marka, uint speed, uint carrying, uint numOfStuff, uint numOfPassengers, string typeOfVehicle)
        { //конструктор класса (с параметрами)
            mark = marka;
            type = typeOfVehicle;
            maxSpeed = speed;
            capacity = carrying; 
            stuff = numOfStuff; 
            passengers = numOfPassengers;
        }

    }
}
