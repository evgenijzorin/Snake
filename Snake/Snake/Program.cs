﻿using System;
using System.Collections.Generic;
using System.Threading; // Thread

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
                // Процесс поглощения пищи
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                //else
                //{
                //}      

                if (Console.KeyAvailable)//Значение true, если нажатие клавиши доступно 
                {
                    ConsoleKeyInfo key = Console.ReadKey();                         
                    snake.HandlyKey(key.Key); // дать команду змейке
                }
                Thread.Sleep(300); // Задержка на 300 милисекунд
                snake.Move();
            }        
            
            Console.ReadLine();
        }   
    }
}
