using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4.Parse
{
    public class Menu
    {
        public void StartMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1.Поиск по коду запчасти");
            Console.WriteLine("2.Поиск по бренду");
            Console.WriteLine("3.Поиск по параметру 'Keyzak'");
            Console.WriteLine("4.По совпадению в наименовании");
            Console.WriteLine("5.Вывести все");
            Console.WriteLine("6.Вывести список сортированный по возрастанию");
        }

        public int UserInput()
        {
            int userInput;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out userInput))
            {
                return userInput;
            }
            else 
            {
                Console.WriteLine("Некорректный ввод"); 
            }
            return userInput;
        }
    }
}
