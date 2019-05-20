using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Airplane : AirTransport
    {
        private int engines;

        public void SetEngines(int numOfEngines)
        {
            engines = numOfEngines;
        }

        public int GetEngines()
        {
            return engines;
        }

        public Airplane() : base()
        {
            engines = 0;
        }

        public Airplane(string marka, int speed, int carrying, int numOfStuff, int numOfPassengers, string typeOfVehicle, string typeOfAirVehicle, int numOfEngines)
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
                    engines = int.Parse(Console.ReadLine());
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
