using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Privetstvie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод переменных
           
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите день нашего рождения:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц нашего рождения:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год нашего рождения:");
            int age =int.Parse(Console.ReadLine());

            //Проверка на високосность года
            int vis;
            if(age%4 == 0)
            {
                 vis = 29;
            }
            else
            {
                vis = 28;
            }

            //Здесь я немного заморочился , и сделал проверку каждого месяца
            //Нахождение max'ого дня в месяце
            int i = 0;
            switch (month)
            {
                case 1: i = 31; break;
                case 2: i = vis; break;
                case 3: i = 31; break;
                case 4: i = 30; break;
                case 5: i = 31; break;
                case 6: i = 30; break;
                case 7: i = 31; break;
                case 8: i = 31; break;
                case 9: i = 30; break;
                case 10: i = 31; break;
                case 11: i = 30; break;
                case 12: i = 31; break;
                default: Console.WriteLine("НЕ ПРАВИЛЬНО ВВЕДЕН МЕСЯЦ"); break;
            }

            int year = 0;

            //Проверка на корректность введенного дня
            if (day <= i && day >= 1)
            {
                if (day > 13 && month > 9) //Нахождение сколько лет пользователю 
                {
                    year = 2020 - age - 1;//Если он родился после 13.9
                }
                else
                {
                    year = 2020 - age;//Если он родился до 13.9
                }

            }
            else
            {
                Console.WriteLine("НЕ ПРАВИЛЬНО ВВЕДЕН ДЕНЬ!!!");
            }

            //Если хоть что-то введено с ошибкой,прог. выводит error
            if (year == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("Привет, {0}. Ваш возраст равен {1} лет. Приятно познакомиться.", name, year);
                Console.ReadKey();
            }
        }
    }
}
