using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module4.Parse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            var path = Path.Combine(Environment.CurrentDirectory, "jsonArmtek.txt");

            var json = File.ReadAllText(path);

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ArmProd>>(json);

            do
            {
                menu.StartMenu();
                Console.Write("Введите значение: ");
                switch (menu.UserInput())
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Поиск по номеру запчасти: ");
                        string InputPin = Console.ReadLine();
                        Search(data, InputPin);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Поиск по бренду: ");
                        string InputBrand = Console.ReadLine();
                        Search(data, InputBrand);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("поиск по параметру 'Keyzak': ");
                        string InputKeyzak = Console.ReadLine();
                        Search(data, InputKeyzak);
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Поиск по наименованию: ");
                        string InputName = Console.ReadLine();
                        SearchByName(data, InputName);
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Вывести список: ");
                        foreach (ArmProd armProd in data)
                        {
                            PrintInfo(armProd);
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.Write("Вывести список сортированный по возрастанию: ");
                        SortByPrice(data);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }

        public static void SortByPrice(List<ArmProd> armProd)
        {
            var sortedPrice = from arm in armProd
                              orderby arm.PRICE ascending
                              select arm;
            foreach (ArmProd arm in sortedPrice)
            {
                PrintInfo(arm);
            }

        }
        public static void Search(List<ArmProd> objects, string userInput)
        {
            foreach (ArmProd obj in objects)
            {
                if (obj.ARTID == userInput || obj.PIN == userInput || obj.BRAND == userInput || obj.KEYZAK == userInput)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintInfo(obj);
                }
            }
            Console.ResetColor();
        }

        public static void SearchByName(List<ArmProd> objects, string userInput)
        {
            foreach (ArmProd obj in objects)
            {
                if (obj.NAME.Contains(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintInfo(obj);
                }
            }
            Console.ResetColor();
        }

        public static void PrintInfo(ArmProd obj)
        {
            Console.WriteLine();
            Console.WriteLine("Бренд: {0}\n" +
                 "Артикул: {1} {2}\n" +
                 "Название: {3}\n" +
                 "ARTID: {4}\n" +
                 "Цена: {5} {6}\n" +
                 "Параметр 'KEYZAK': {7}\n" +
                 "Наличие: {8}", obj.BRAND, obj.ARTID, obj.PIN, obj.NAME, obj.ARTID, obj.PRICE, obj.WAERS, obj.KEYZAK, obj.RVALUE);
        }
    }
}
