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

        public Tanker(string marka, int speed, int carrying, int numOfStuff, int numOfPassengers, string typeOfVehicle, string typeOfWaterVehicle, string dest)
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
