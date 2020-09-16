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

            Console.WriteLine("Введите день нашего рождения:");
            int day = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Введите месяц нашего рождения:");
            int month = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Введите год нашего рождения:");
            int year =int.Parse(Console.ReadLine());

            //Проверка на корректность ввода месяца,года.Присваивание кол-вa дней в этом месяце.
            //Если месяц или год указан неверно, то условие следующего  метода auto неверен
            int DayInMounth = 0;
            if ((month > 0 && month <= 12)  && (year > 0 && year <= yearnow)) 
            { 
                DayInMounth = DateTime.DaysInMonth(year, month);
            }

            //Проверка на коректность ввода дня,а заодно и на високосность года в год рождения 
            //(Благо метод DayInMonth позваляет)
            int yearperson = -1;
            if (day <= DayInMounth && day >0)
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
                Console.WriteLine("НЕВЕРНО ВВЕДЕНА ДАТА");
            }

            if (yearperson != -1)
            {
                Console.WriteLine("Привет, {0} .Ваш возраст равен {1} лет.Приятно познакомиться.", name, yearperson);
            }



         
        }
    }
}
