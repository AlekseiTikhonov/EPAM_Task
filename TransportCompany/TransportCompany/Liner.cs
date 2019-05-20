using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Liner : WaterTransport
    {
        private int range;

        public void SetRange(int rangeWithotExtraFuel)
        {
            range = rangeWithotExtraFuel;
        }

        public int GetRange()
        {
            return range;
        }

        public Liner() : base()
        {
            range = 0;
        }

        public Liner(string marka, int speed, int carrying, int numOfStuff, int numOfPassengers, string typeOfVehicle, string typeOfWaterVehicle, int rangeWithotExtraFuel)
            : base(marka, speed, carrying, numOfStuff, numOfPassengers, typeOfVehicle, typeOfWaterVehicle)
        {
            range = rangeWithotExtraFuel;
        }

        public void SetAllInfo()
        {
            bool check = true;
            Console.Write("Введите марку лайнера: ");
            string marka = Console.ReadLine();
            SetMark(marka);
            while (check)
            {
                try
                {
                    Console.Write("Введите максимальное расстояние без дозаправки: ");
                    range = int.Parse(Console.ReadLine());
                    SetRange(range);
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
            SetType("Водная");
            SetTypeWater("Лайнеры");
            Console.WriteLine("Лайнер был успешно добавлен");
        }
        public string Information()
        {
            return "\n\tТип техники: " + GetTypeOfVehicle() + "\n\t" + "Категория: " + GetTypeWaterVehicle() + "\n\t" + "Марка: " + GetMark() + "\n\t" + "Максимальное расстояние без дозаправки: "
            + GetRange() + "\n\t" + "Максимальная скорость: " + GetMaxSpeed() + "\n\t" + "Грузоподъемность: " + GetCapacity() + "\n\t" + "Количество персонала: "
            + GetStuff() + "\n\t" + "Количество пассажиров: " + GetPassengers() + "\n";
        }
    }
}
