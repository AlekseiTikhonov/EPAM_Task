using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Tanker : WaterTransport
    {
        private string destination;

        public void SetDestination(string dest)
        {
            destination = dest;
        }

        public string GetDestination()
        {
            return destination;
        }

        public Tanker() : base()
        {
            destination="";
        }

        public Tanker(string marka, uint speed, uint carrying, uint numOfStuff, uint numOfPassengers, string typeOfVehicle, string typeOfWaterVehicle, string dest)
            : base(marka, speed, carrying, numOfStuff, numOfPassengers, typeOfVehicle, typeOfWaterVehicle)
        {
            destination = dest;
        }

        public void SetAllInfo()
        {
            bool check = true;
            Console.Write("Введите марку танкера: ");
            string marka = Console.ReadLine();
            SetMark(marka);
            Console.Write("Введите пункт назначения: ");
            destination = Console.ReadLine();
            SetDestination(destination);
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
            SetType("Водная");
            SetTypeWater("Танкеры");
            Console.WriteLine("Танкер был успешно добавлен");
        }
        public string Information()
        {
            return "\n\tТип техники: " + GetTypeOfVehicle() + "\n\t" + "Категория: " + GetTypeWaterVehicle() + "\n\t" + "Марка: " + GetMark() + "\n\t" + "Пункт назначения: "
            + GetDestination() + "\n\t" + "Максимальная скорость: " + GetMaxSpeed() + "\n\t" + "Грузоподъемность: " + GetCapacity() + "\n\t" + "Количество персонала: "
            + GetStuff() + "\n\t" + "Количество пассажиров: " + GetPassengers() + "\n";
        }
    }
}
