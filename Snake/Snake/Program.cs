using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // инкапсуляция - свойство системы объединить данные и методы реализации какой либо сущьности в классе и скрыть их от пользователя
            Point p1 = new Point(1, 3, '*');
            p1.Draw(); // вызов метода
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HoryzontLine line = new HoryzontLine(5,10,8, '+');
            line.Draw();
            VertycalLine vLine = new VertycalLine(2, 15,10, '*');
            vLine.Draw();





            Console.ReadLine();
        }   
    }
}
