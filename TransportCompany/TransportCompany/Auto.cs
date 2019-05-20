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

        public Auto(string marka, int speed, int carrying, int numOfStuff, int numOfPassengers, string typeOfVehicle, string typeOfLandVehicle, string name)
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
                    int speed = int.Parse(Console.ReadLine());
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
                    int carrying = int.Parse(Console.ReadLine());
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
                    int numOfStuff = int.Parse(Console.ReadLine());
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
                    int numOfPassengers = int.Parse(Console.ReadLine());
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
