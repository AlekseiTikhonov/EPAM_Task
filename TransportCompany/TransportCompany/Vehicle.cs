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
        private int maxSpeed; // максимальная скорость
        private int capacity; // грузоподъемность
        private int stuff; // количество персонала
        private int passengers; // количество пассажиров
        
        public void SetMark(string marka)
        { 
            mark = marka; 
        }
        public void SetType(string typeOfVehicle)
        {
            type = typeOfVehicle;
        }
        public void SetMaxSpeed(int speed)
        { 
            maxSpeed = speed; 
        }
        public void SetCapacity(int carrying)
        {
            capacity = carrying;
        }
        public void SetStuff(int numOfStuff)
        {
            stuff = numOfStuff;
        }
        public void SetPassengers(int numOfPassengers)
        {
            passengers = numOfPassengers;
        }

        public int GetMaxSpeed()
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

        public int GetCapacity()
        {
            return capacity;
        }
        public int GetStuff()
        {
            return stuff;
        }
        public int GetPassengers()
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
        public Vehicle(string marka, int speed, int carrying, int numOfStuff, int numOfPassengers, string typeOfVehicle)
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
