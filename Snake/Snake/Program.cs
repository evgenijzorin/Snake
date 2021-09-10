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
            Point p3 = new Point(5, 12, 'r');
            p3.Draw();

            List<int> numList = new List<int>();

            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }  
            numList.RemoveAt(0);

            List<Point> listPoint = new List<Point>();
            listPoint.Add(p1);
            listPoint.Add(p2);
            listPoint.Add(p3);



            Console.ReadLine();
        }   
    }
}
