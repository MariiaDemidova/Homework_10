using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(45, 5, 5);
            angle.Print();
            double radian = angle.ToRadians();
            Console.WriteLine("Угол в радианах = {0:F4}", radian);
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            set
            {
                if (value > 0 && value < 180)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Недопустимое значение градусов");
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
                    min = value;
                }
                else
                {
                    Console.WriteLine("Недопустимое значение минут");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Недопустимое значение секунд");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public double ToRadians()
        {
            double radian = (Gradus + ((Sec / 60) + Min) / 60) * Math.PI / 180;
            return radian;
        }
        public void Print()
        {
            if (Min == 0 || Sec == 0)
            {
                if (Min == 0 && Sec == 0)
                {
                    Console.WriteLine("Создан угол: {0} gradus", Gradus);
                }
                else
                { 
                    if (Min == 0)
                    {
                        Console.WriteLine("Создан угол: {0} gradus, {1} sec", Gradus, Sec);
                    }
                    else
                    {
                        Console.WriteLine("Создан угол: {0} gradus, {1} min", Gradus, Min);
                    }
                }
            }
            else
            {
                Console.WriteLine("Создан угол: {0} gradus, {1} min, {2} sec", Gradus, Min, Sec);
            }
        }
    }
}
