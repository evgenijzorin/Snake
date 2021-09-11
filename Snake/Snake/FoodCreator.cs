using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHight;
        char sym;

        Random random = new Random();


        public FoodCreator(int _mapWidth, int _mapHight, char _sym)
        {
            mapWidth = _mapWidth; // можно заменить на this.mapLength и сделать переменные одноименные
            mapHight = _mapHight;
            sym = _sym;
        }

        internal Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHight - 2);
            return new Point(x, y, sym);
        }
    }
}
