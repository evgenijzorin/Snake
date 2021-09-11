using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // размер окна
            Console.SetBufferSize(80, 25); // Устанавливает заданные значения высоты и ширины буферной области экрана.

            // границы игровой зоны
            HoryzontLine upLine = new HoryzontLine(0,78,0, '+');
            HoryzontLine downLine = new HoryzontLine(0, 78, 24, '+');
            VertycalLine rightLine = new VertycalLine(0, 24, 78, '+');
            VertycalLine leftLine = new VertycalLine(0, 24, 0, '+');
            upLine.Draw();
            downLine.Draw();
            rightLine.Draw();
            leftLine.Draw();

            Point p1 = new Point(1, 3, '*');
            // p1.Draw(); // вызов метода
            Snake snake = new Snake(p1, 4, Direction.Right);
            snake.Draw();


            Console.ReadLine();
        }   
    }
}
