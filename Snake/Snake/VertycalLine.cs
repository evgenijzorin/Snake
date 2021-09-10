using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertycalLine
    {
        List<Point> pList; // поле
        /// <summary>
        ///  класс вертикальная линия
        /// </summary>
        public VertycalLine(int yTop, int yBotom, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBotom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
