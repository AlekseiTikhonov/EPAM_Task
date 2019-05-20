using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Helicopter : AirTransport
    {
        private int blades;

        public void SetBlades(int numOfBlades)
        {
            blades = numOfBlades;
        }

        public int GetBlades()
        {
            return blades;
        }

        public Helicopter() : base()
        {
            blades = 0;
        }

        public Helicopter(string marka, int speed, int carrying, int numOfStuff, int numOfPassengers, string typeOfVehicle, string typeOfAirVehicle, int numOfBlades)
            : base(marka, speed, carrying, numOfStuff, numOfPassengers, typeOfVehicle, typeOfAirVehicle)
        {
            blades = numOfBlades;
        }

        public void SetAllInfo()
        {
            bool check = true;
            Console.Write("Введите марку вертолёта: ");
            string marka = Console.ReadLine();
            SetMark(marka);
            while (check)
            {
                try
                {
                    Console.Write("Введите количество лопастей: ");
                    blades = int.Parse(Console.ReadLine());
                    SetBlades(blades);
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
            SetTypeAir("Вертолёты");
            Console.WriteLine("Вертолёт был успешно добавлен");
        }
        public string Information()
        {
            return "\n\tТип техники: " + GetTypeOfVehicle() + "\n\t" + "Категория: " + GetTypeAirVehicle() + "\n\t" + "Марка: " + GetMark() + "\n\t" + "Количество лопастей: "
            + GetBlades() + "\n\t" + "Максимальная скорость: " + GetMaxSpeed() + "\n\t" + "Грузоподъемность: " + GetCapacity() + "\n\t" + "Количество персонала: "
            + GetStuff() + "\n\t" + "Количество пассажиров: " + GetPassengers() + "\n";
        }
    }
}

