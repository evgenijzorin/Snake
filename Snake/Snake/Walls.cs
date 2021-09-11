using System.Collections.Generic;


namespace Snake
{
    class Walls
    {
        // список стен
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHight)
        {
            wallList = new List<Figure>();
            // границы игровой зоны
            HoryzontLine upLine = new HoryzontLine(0, mapWidth - 2, 0, '+');
            HoryzontLine downLine = new HoryzontLine(0, mapWidth - 2, mapHight - 1, '+');
            VertycalLine rightLine = new VertycalLine(0, mapHight - 1, mapWidth - 2, '+');
            VertycalLine leftLine = new VertycalLine(0, mapHight - 1, 0, '+');
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(rightLine);
            wallList.Add(leftLine);
        }

        public bool IsHit (Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;

        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }



    }
}