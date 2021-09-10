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
        // Конструктор по умолч
        public Point ()
        {            
        }
    }
}
