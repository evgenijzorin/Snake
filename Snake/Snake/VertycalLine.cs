using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertycalLine : Figure // класс наследуется от фигуры
    {
        /// <summary>
        ///  класс вертикальная линия
        /// </summary>
        public VertycalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }


    }
}
