using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Basic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите, что вы хотите сделать (1,2)");
            Console.WriteLine("1 - Добавить транспортное средство");
            Console.WriteLine("2 - Просмотреть транспортные средства");
            switch (Choosing(2))
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №1");
                    Console.WriteLine("Выберите тип транспорта, который хотите добавить (1,2,3)");
                    Console.WriteLine("1 - Наземный");
                    Console.WriteLine("2 - Водный");
                    Console.WriteLine("3 - Воздушный");
                    ProcessTypeOfVehicle(Choosing(3));
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали пункт №2");
                    break;
            }
            Console.ReadLine();
            
        }

        private static int Choosing (int num)
        {
            bool check = true;
            int choice = 0;
            while (check)
             {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice >=1 && choice <= num)
                    {
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, введите цифру, от 1 до {0}", num);
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Пожалуйста, введите цифру, от 1 до {0}",num);
                }
            }
            return choice;
        }

        private static void ProcessTypeOfVehicle (int choosing)
        {
            switch (choosing)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №1, наземный транспорт");       
                    Console.WriteLine("Выберите категорию транспорта (1,2)");
                    Console.WriteLine("1 - Поезда");
                    Console.WriteLine("2 - Автомобили");
                    ProcessTypeOfLandTransport(Choosing(2));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №2, водный транспорт");
                    Console.WriteLine("Выберите категорию транспорта (1,2)");
                    Console.WriteLine("1 - Лайнеры");
                    Console.WriteLine("2 - Танкеры");
                    ProcessTypeOfWaterTransport(Choosing(2));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №3, воздушный транспорт");
                    Console.WriteLine("Выберите категорию транспорта (1,2)");
                    Console.WriteLine("1 - Самолёты");
                    Console.WriteLine("2 - Вертолёты");
                    ProcessTypeOfAirTransport(Choosing(2));
                    break;
            }
        }

        private static void ProcessTypeOfLandTransport (int choosing)
        {
            switch (choosing)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №1, поезда");
                    Train train = new Train();
                    train.SetAllInfo();
                    Console.WriteLine(train.Information());
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №2, автомобили");
                    Auto auto = new Auto();
                    auto.SetAllInfo();
                    Console.WriteLine(auto.Information());
                    break;
            }
        }
        private static void ProcessTypeOfWaterTransport(int choosing)
        {
            switch (choosing)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №1, лайнеры");
                    Liner liner = new Liner();
                    liner.SetAllInfo();
                    Console.WriteLine(liner.Information());
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №2, танкеры");
                    Tanker tanker = new Tanker();
                    tanker.SetAllInfo();
                    Console.WriteLine(tanker.Information());
                    break;
            }
        }
        private static void ProcessTypeOfAirTransport(int choosing)
        {
            switch (choosing)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №1, самолёты");
                    Airplane airplane = new Airplane();
                    airplane.SetAllInfo();
                    Console.WriteLine(airplane.Information());
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №2, вертолёты");
                    Helicopter helicopter = new Helicopter();
                    helicopter.SetAllInfo();
                    Console.WriteLine(helicopter.Information());
                    break;
            }
        }
    }
}
