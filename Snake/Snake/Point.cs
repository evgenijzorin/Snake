using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        // инкапсуляция - свойство системы объединить данные и методы реализации какой либо сущьности в классе и скрыть их от пользователя
        public int x;
        public int y;
        public char sym;
        public void Draw() // аргументы у функции - поля класса
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        // Конструктор c вводом всех параметров
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        // Конструктор задания точки с помощью другой точки
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        // Конструктор по умолч
        public Point ()
        {            
        }
        public void Move(int offset, Direction direction) // offset - смещение
        {
            if (direction == Direction.Left)
            {
                x = x - offset;
            }
            else if (direction == Direction.Right)
            {
                x = x + offset;
            }
            else if (direction == Direction.Up)
            {
                y = y + offset;
            }
            else if (direction == Direction.Down)
            {
                y = y - offset;
            }
        }


    }
}
