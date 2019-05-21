using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Basic
    {
        static List<Train> train = new List<Train>();
        static List<Auto> auto = new List<Auto>();
        static List<Liner> liner = new List<Liner>();
        static List<Tanker> tanker = new List<Tanker>();
        static List<Airplane> airplane = new List<Airplane>();
        static List<Helicopter> helicopter = new List<Helicopter>();

        static void Main(string[] args)
        {
            ShowMainMenu();
            Console.ReadLine();
        }
        private static void ShowMainMenu()
        {
            Console.Clear();
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
                    ShowAllTransport();
                    Console.WriteLine("Нажмите Enter, чтобы выйти в главное меню");
                    Console.ReadLine();
                    ShowMainMenu();
                    break;
            }

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
                    AddTrain();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №2, автомобили");
                    AddAuto();
                    break;
            }
        }


        private static void AddTrain()
        {
            train.Add(new Train());
            train.ElementAt(train.Count - 1).SetAllInfo();
            Console.WriteLine(train.ElementAt(train.Count - 1).Information());
            OneMoreOrMenu(train.ElementAt(train.Count - 1).GetTypeLandVehicle());
        }

        private static void AddAuto()
        {
            auto.Add(new Auto());
            auto.ElementAt(auto.Count - 1).SetAllInfo();
            Console.WriteLine(auto.ElementAt(auto.Count - 1).Information());
            OneMoreOrMenu(auto.ElementAt(auto.Count - 1).GetTypeLandVehicle());
        }

        private static void ProcessTypeOfWaterTransport(int choosing)
        {
            switch (choosing)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №1, лайнеры");
                    AddLiner();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №2, танкеры");
                    AddTanker();
                    break;
            }
        }


        private static void AddLiner()
        {
            liner.Add(new Liner());
            liner.ElementAt(liner.Count - 1).SetAllInfo();
            Console.WriteLine(liner.ElementAt(liner.Count - 1).Information());
            OneMoreOrMenu(liner.ElementAt(liner.Count - 1).GetTypeWaterVehicle());
        }

        private static void AddTanker()
        {
            tanker.Add(new Tanker());
            tanker.ElementAt(tanker.Count - 1).SetAllInfo();
            Console.WriteLine(tanker.ElementAt(tanker.Count - 1).Information());
            OneMoreOrMenu(tanker.ElementAt(tanker.Count - 1).GetTypeWaterVehicle());
        }
        
        private static void ProcessTypeOfAirTransport(int choosing)
        {
            switch (choosing)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №1, самолёты");
                    AddAirplane();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали пункт №2, вертолёты");
                    AddHelicopter();
                    break;
            }
        }
        private static void AddAirplane ()
        {
            airplane.Add(new Airplane());
            airplane.ElementAt(airplane.Count - 1).SetAllInfo();
            Console.WriteLine(airplane.ElementAt(airplane.Count - 1).Information());
            OneMoreOrMenu(airplane.ElementAt(airplane.Count - 1).GetTypeAirVehicle());

        }
        private static void AddHelicopter()
        {
            helicopter.Add(new Helicopter());
            helicopter.ElementAt(helicopter.Count - 1).SetAllInfo();
            Console.WriteLine(helicopter.ElementAt(helicopter.Count - 1).Information());
            OneMoreOrMenu(helicopter.ElementAt(helicopter.Count - 1).GetTypeAirVehicle());
        }

        private static void OneMoreOrMenu(string type)
        {
            Console.WriteLine("Хотите-ли вы добавить ещё один объет в класс {0}?",type);
            Console.WriteLine("1 - Да");
            Console.WriteLine("2 - Вернуться в главное меню");
            switch (Choosing(2))
            {
                case 1:
                    if (type.Equals("Автомобили")) AddAuto();
                    else if (type.Equals("Поезда")) AddTrain();
                    else if (type.Equals("Лайнеры")) AddLiner();
                    else if (type.Equals("Танкеры")) AddTanker();
                    else if (type.Equals("Самолёты")) AddAirplane();
                    else if (type.Equals("Вертолёты")) AddHelicopter();
                    break;
                case 2:
                    ShowMainMenu();
                    break;
            }
        }

        private static void ShowAllTransport ()
        {
            Console.Clear();

            if (auto.Count == 0 && airplane.Count == 0 && train.Count == 0 && tanker.Count == 0 && liner.Count == 0 && helicopter.Count == 0)
                Console.WriteLine("У нас пока нету добавленных транспортных средств");
            else
            {
                Console.WriteLine("Вот наши транспортные средства:");
                foreach(Auto a in auto)
                {
                    Console.WriteLine(a.Information()); 
                }
                foreach (Train a in train)
                {
                    Console.WriteLine(a.Information());
                }
                foreach (Liner a in liner)
                {
                    Console.WriteLine(a.Information());
                }
                foreach (Tanker a in tanker)
                {
                    Console.WriteLine(a.Information());
                }
                foreach (Airplane a in airplane)
                {
                    Console.WriteLine(a.Information());
                }
                foreach (Helicopter a in helicopter)
                {
                    Console.WriteLine(a.Information());
                }
            }

        }
    }
}
