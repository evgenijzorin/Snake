using System;
using System.Collections.Generic;
using System.Threading; // Thread

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int mapWidth = 80;
            int mapHight = 25;
            Console.SetWindowSize(80, 25); // размер окна
            Console.SetBufferSize(80, 25); // Устанавливает заданные значения высоты и ширины буферной области экрана.


            // Стены
            Walls walls = new Walls(mapWidth, mapHight);
            walls.Draw();

            // Создание базовой точки
            Point p1 = new Point(1, 3, '*');
            // Создание змейки
            Snake snake = new Snake(p1, 4, Direction.Right);
            snake.Draw();

            // Создание еды
            FoodCreator foodCreator = new FoodCreator(80,25,'$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                // проверка пересечения препятствия
                
                if (walls.IsHit(snake) || snake.IsHitSnakeTail(snake))
                    break;
                // Процесс поглощения пищи
                if 
                    (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                
                if (Console.KeyAvailable)//Значение true, если нажатие клавиши доступно 
                {
                    ConsoleKeyInfo key = Console.ReadKey();                         
                    snake.HandlyKey(key.Key); // дать команду змейке
                }
                Thread.Sleep(300); // Задержка на 300 милисекунд
                snake.Move();
            }   
        }   
    }
}
