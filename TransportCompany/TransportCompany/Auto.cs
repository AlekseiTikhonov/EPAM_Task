using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Auto : LandTransport
    {
        private string model;
        //мощность можно добавить

        public void SetModel(string name)
        {
            model = name;
        }

        public string GetModel()
        {
            return model;
        }

        public Auto() : base()
        {
            model = "Нет модели";
        }

        public Auto(string marka, uint speed, uint carrying, uint numOfStuff, uint numOfPassengers, string typeOfVehicle, string typeOfLandVehicle, string name)
            : base(marka, speed, carrying, numOfStuff, numOfPassengers, typeOfVehicle, typeOfLandVehicle)
        {
            model = name;
        }

        public void SetAllInfo()
        {
            bool check = true;
            Console.Write("Введите марку автомобильного транспорта: ");
            string marka = Console.ReadLine();
            SetMark(marka);
            Console.Write("Введите модель автомобиля: ");
            model = Console.ReadLine();
            while (check)
            {
                try
                {
                    Console.Write("Введите максимальную скорость: ");
                    uint speed = uint.Parse(Console.ReadLine());
                    SetMaxSpeed(speed);
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Произошла ошибка, введите число ");
                }
            }
            check = true;
            while (check)
            {
                try
                {
                    Console.Write("Введите грузоподъемность (число) тонн: ");
                    uint carrying = uint.Parse(Console.ReadLine());
                    SetCapacity(carrying);
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Произошла ошибка, введите число ");
                }
            }
            check = true;
            while (check)
            {
                try
                {
                    Console.Write("Введите количество персонала, необходимого для эксплуатации: ");
                    uint numOfStuff = uint.Parse(Console.ReadLine());
                    SetStuff(numOfStuff);
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Произошла ошибка, введите число ");
                }
            }
            check = true;
            while (check)
            {
                try
                {
                    Console.Write("Введите максимальное количество пассажиров: ");
                    uint numOfPassengers = uint.Parse(Console.ReadLine());
                    SetPassengers(numOfPassengers);
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Произошла ошибка, введите число ");
                }
            } 
            SetType("Наземная");
            SetTypeLand("Автомобили");
            Console.WriteLine("Автомобиль был успешно добавлен");
        }
        public string Information()
        {
            return "\n\tТип техники: " + GetTypeOfVehicle() + "\n\t" + "Категория: " + GetTypeLandVehicle() + "\n\t" + "Марка: " + GetMark() + "\n\t" + "Модель: "
            + GetModel() + "\n\t" + "Максимальная скорость: " + GetMaxSpeed() + "\n\t" + "Грузоподъемность: " + GetCapacity() + "\n\t" + "Количество персонала: "
            + GetStuff() +"\n\t" + "Количество пассажиров: " + GetPassengers()  + "\n";
        }

    }
}
