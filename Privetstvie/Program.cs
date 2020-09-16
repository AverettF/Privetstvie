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

            int yearnow = DateTime.Now.Year; //2020
            int monthnow = DateTime.Now.Month;// 09
            int daynow = DateTime.Now.Day;//16

            //Ввод переменных
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();  //Ввод имени

            Console.WriteLine("Введите день нашего рождения:");
            int day = Convert.ToInt32(Console.ReadLine()); //Ввод дня

            Console.WriteLine("Введите месяц нашего рождения:");
            int month = Convert.ToInt32(Console.ReadLine()); //Ввод месяца

            Console.WriteLine("Введите год нашего рождения:");
            int year =int.Parse(Console.ReadLine());//Ввод года

            //Проверка на коректность ввода дня месяца,а заодно и на високосность года в год рождения 
            //(Благо метод позваляет)
            int yearperson = 0;
            int DayInMounth = DateTime.DaysInMonth(year, month);
            if (day <= DayInMounth && day >0)
            {
                if( day> daynow && month > monthnow)
                {
                    yearperson = yearnow - year;
                }
                else
                {
                    yearperson = yearnow - year - 1;
                }

            }
  
            Console.WriteLine("Привет, {0} .Ваш возраст равен {1} лет.Приятно познакомиться.",name,yearperson);

        }
    }
}
