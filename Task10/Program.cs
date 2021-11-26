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
            double sumRadians = angle.ToRadians(20, 10, 20);
            if (sumRadians < 0)
            {
                Console.WriteLine("Значения угла введены некорректно, невозможно перевести угол в радианы");
            }
            else
            {
                Console.WriteLine("Значение угла в радианах равно {0:f6}", sumRadians);
            }
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int minute;
        int second;

        public int Gradus
        {
            set
            {
                if (value < 0 || value > 180)
                {
                    Console.WriteLine("Угол не может быть отрицательным либо больше 180°!");
                }
                else
                {
                    gradus = value;
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
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Минута не может быть отрицательной либо больше 60!");
                }
                else
                {
                    minute = value;
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
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Секунда не может быть отрицательной либо больше 60\"!");
                }
                else
                {
                    second = value;
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
        public double ToRadians(int gradus, int minute, int second)
        {
            double radians1 = 0;
            double radians2 = 0;
            double radians3 = 0;
            radians1 = (Math.PI / 180) * gradus;
            radians2 = (Math.PI / (180 * 60)) * minute;
            return radians1 + radians2 + radians3;
        }
        public void Print()
        {
            Console.WriteLine("Значение угла: {0}°{1}\'{2}\"", Gradus, Min, Second);
        }
    }
}
