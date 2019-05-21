using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Airplane : AirTransport
    {
        private uint engines;

        public void SetEngines(uint numOfEngines)
        {
            engines = numOfEngines;
        }

        public uint GetEngines()
        {
            return engines;
        }

        public Airplane() : base()
        {
            engines = 0;
        }

        public Airplane(string marka, uint speed, uint carrying, uint numOfStuff, uint numOfPassengers, string typeOfVehicle, string typeOfAirVehicle, uint numOfEngines)
            : base(marka, speed, carrying, numOfStuff, numOfPassengers, typeOfVehicle, typeOfAirVehicle)
        {
            engines = numOfEngines;
        }

        public void SetAllInfo()
        {
            bool check = true;
            Console.Write("Введите марку самолёта: ");
            string marka = Console.ReadLine();
            SetMark(marka);
            while (check)
            {
                try
                {
                    Console.Write("Введите количество двигателей: ");
                    engines = uint.Parse(Console.ReadLine());
                    SetEngines(engines);
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
            SetType("Воздушная");
            SetTypeAir("Самолёты");
            Console.WriteLine("Самолёт был успешно добавлен");
        }
        public string Information()
        {
            return "\n\tТип техники: " + GetTypeOfVehicle() + "\n\t" + "Категория: " + GetTypeAirVehicle() + "\n\t" + "Марка: " + GetMark() + "\n\t" + "Количество двигателей: "
            + GetEngines() + "\n\t" + "Максимальная скорость: " + GetMaxSpeed() + "\n\t" + "Грузоподъемность: " + GetCapacity() + "\n\t" + "Количество персонала: "
            + GetStuff() + "\n\t" + "Количество пассажиров: " + GetPassengers() + "\n";
        }
    }
}
