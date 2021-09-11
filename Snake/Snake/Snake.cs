using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        /// <summary>
        /// класс змейка
        /// </summary>
        /// <param name="tail">Положение хвоста</param>
        /// <param name="length">Длина змейки</param>
        /// <param name="direction">Направление змейки</param>
        public Snake (Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>(); // Создаем новый экземпляр списка точек
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }

        }

        internal void Move() // internal - внутренний, модификатор доступа только внутри класса
        {
            Point tail = pList.First(); // хвост змейки - возвратить первый элемент списка
            pList.Remove(tail); // Удалить хвостовую точку змейки
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last(); // последняя точка списка - голова змейки
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            } 
            else
            {
                return false;
            }

        }

        public void HandlyKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
        }
    }
}
