using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {

        /// <summary>
        /// класс змейка
        /// </summary>
        /// <param name="tail">Положение хвоста</param>
        /// <param name="length">Длина змейки</param>
        /// <param name="direction">Направление змейки</param>
        public Snake (Point tail, int length, Direction direction)
        {
            pList = new List<Point>(); // Создаем новый экземпляр списка точек
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }

        }

    }
}
