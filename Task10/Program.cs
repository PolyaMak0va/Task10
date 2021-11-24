using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    /* Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
     * Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных. 
     * Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
     * Создать объект на основе разработанного класса. Осуществить использование объекта в программе.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(20, 10, 20);
            angle.Print();
            Console.ReadKey();
        }

    }
    class Angle
    {
        int gradus;
        int minute;
        int second;
        //public double Radians { get; set; }

        public int Gradus
        {
            set
            {
                if (value >= 0 && value < 180)
                {
                    gradus = value;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Угол не может быть отрицательным!");
                }
                else
                {
                    Console.WriteLine("Угол не должен превышать 180°!");
                }
            }
            get
            {
                return gradus;
            }
        }

        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Минута не может быть отрицательной!");
                }
                else
                {
                    Console.WriteLine("Минута не может быть больше 60\'!");
                }
            }
            get
            {
                return minute;
            }
        }

        public int Second
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    second = value;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Секунда не может быть отрицательной!");
                }
                else
                {
                    Console.WriteLine("Секунда не может быть больше 60\"!");
                }
            }
            get
            {
                return second;
            }
        }

        public Angle(int gradus, int minute, int second)
        {
            Gradus = gradus;
            Min = minute;
            Second = second;
        }
        public double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
        public void Print()
        {
            Console.WriteLine("Значение угла: {0}°{1}\'{2}\"", Gradus, Min, Second);
        }
    }
    //public static class NumericExtensions
    //{
    //    public static double ToRadians(this double val)
    //    {
    //        return (Math.PI / 180) * val;
    //    }
    //}
}
