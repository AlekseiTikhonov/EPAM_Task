using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Train : LandTransport
    {
        private uint coaches;

        public void SetCoaches(uint numOfCoaches)
        {
            coaches = numOfCoaches;
        }

        public uint GetCoaches()
        {
            return coaches;
        }

        public Train() : base()
        {
            coaches = 0;
        }

        public Train(string marka, uint speed, uint carrying, uint numOfStuff, uint numOfPassengers, string typeOfVehicle, string typeOfLandVehicle, uint numOfCoaches)
            : base(marka, speed, carrying, numOfStuff, numOfPassengers, typeOfVehicle, typeOfLandVehicle)
        {
            coaches = numOfCoaches;
        }

        public void SetAllInfo()
        {
            bool check = true;
            Console.Write("Введите марку поезда: ");
            string marka = Console.ReadLine();
            SetMark(marka);
            while (check)
            {
                try
                {
                    Console.Write("Введите количество вагонов: ");
                    coaches = uint.Parse(Console.ReadLine());
                    SetCoaches(coaches);
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
            SetTypeLand("Поезда");
            Console.WriteLine("Поезд был успешно добавлен");
        }
        public string Information()
        {
            return "\n\tТип техники: " + GetTypeOfVehicle() + "\n\t" + "Категория: " + GetTypeLandVehicle() + "\n\t" + "Марка: " + GetMark() + "\n\t" + "Количество вагонов: "
            + GetCoaches() + "\n\t" + "Максимальная скорость: " + GetMaxSpeed() + "\n\t" + "Грузоподъемность: " + GetCapacity() + "\n\t" + "Количество персонала: "
            + GetStuff() + "\n\t" + "Количество пассажиров: " + GetPassengers() + "\n";
        }

    }
}
