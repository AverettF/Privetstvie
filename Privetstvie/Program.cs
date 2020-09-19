using System;
using System.Collections.Generic;
using System.Data;
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
            //Переменные с сегодняшней датой
            int yearnow = DateTime.Now.Year; 
            int monthnow = DateTime.Now.Month;
            int daynow = DateTime.Now.Day;

            //Ввод переменных
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();  

            Console.WriteLine("Введите номер дня даты вашего рождения:");
            int day = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Введите номер месяца даты вашего рождения:");
            int month = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Введите номер года даты вашего рождения:");
            int year =int.Parse(Console.ReadLine());


            //Проверка на корректность ввода месяца,года.Присваивание кол-вa дней в месяц рождения.
            //Если месяц или год указан неверно, то условие следующего  метода auto неверен
            int DayInMonth = 0;
            int Feb = 0;
            if ((month > 0 && month <= 12) && (year > 0 && year <= yearnow))
            {
                //Проверка на високосность года
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)   //  DayInMounth = DateTime.DaysInMonth(year, month);
                {
                    Feb = 29;
                }
                else
                {
                    Feb = 28;
                }

                switch (month)
                {
                    case 1: DayInMonth = 31; break;
                    case 2: DayInMonth = Feb; break;
                    case 3: DayInMonth = 31; break;
                    case 4: DayInMonth = 30; break;
                    case 5: DayInMonth = 31; break;
                    case 6: DayInMonth = 30; break;
                    case 7: DayInMonth = 31; break;
                    case 8: DayInMonth = 31; break;
                    case 9: DayInMonth = 30; break;
                    case 10: DayInMonth = 31; break;
                    case 11: DayInMonth = 30; break;
                    case 12: DayInMonth = 31; break;
                    default: Console.WriteLine("НЕ ПРАВИЛЬНО ВВЕДЕН МЕСЯЦ"); break;
                }

            }


            //Проверка на коректность ввода дня и был ли день рождения в этом году 
            int yearperson = -1;
            if (day <= DayInMonth && day >0)
            {
                
                if( (day> daynow && month >= monthnow) || month >monthnow)
                {
                    yearperson = yearnow - year-1;
                }
                else
                {
                    yearperson = yearnow - year ;
                }
            }
            else
            {
                Console.WriteLine("НЕВЕРНО ВВЕДЕНА ДАТА!!!!!");
            }

            if (yearperson != -1)
            {
                Console.WriteLine("Привет, {0} .Ваш возраст равен {1} лет.Приятно познакомиться.", name, yearperson);
            }

        }
    }
}
