using System;

namespace Game.Core
{
    internal class Game
    {
        private Map map;
        private Hero hero;

        internal void Run()
        {
            Initailize();
            Play();
        }

        private void Play()
        {
            bool gameInProgress = true;
            do
            {
                //DrawMap
                DrawMap();
                //GetCommand
                GetInput();
                //Act
                //DrawMap
                //Enemy Action
                //Drawmap
                //Console.ReadKey();


            } while (gameInProgress);
        }

        private void GetInput()
        {
            var keyPressed = UI.GetKey();
           
            switch (keyPressed)
            {
               
                case ConsoleKey.LeftArrow:
                    Move(hero.Cell.Y, hero.Cell.X - 1);
                    break;
                case ConsoleKey.RightArrow:
                    Move(hero.Cell.Y, hero.Cell.X + 1);
                    break;
                case ConsoleKey.UpArrow:
                    Move(hero.Cell.Y - 1, hero.Cell.X);
                    break;
                case ConsoleKey.DownArrow:
                    Move(hero.Cell.Y + 1, hero.Cell.X);
                    break;
                default:
                    break;
            }
        }

        private void Move(int y, int x)
        {
            var newPosition = map.GetCell(y, x);
            if (newPosition != null) hero.Cell = newPosition;
        }

        private void DrawMap()
        {
            UI.Clear();
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y, x);
                    IDrawable drawable = cell;

                    foreach (var creature in map.Creatures)
                    {
                        if(creature.Cell == cell)
                        {
                            drawable = creature;
                            break;
                        }
                    }

                    Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White;
                    Console.Write(drawable.Symbol);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void Initailize()
        {
            //Todo: Read from config
            //Todo: Random placement
            map = new Map(width: 10, height: 10);
            //ToDo check for null
            var heroCell = map.GetCell(0, 0);
            hero = new Hero(heroCell);
            map.Creatures.Add(hero);
        }
    }
}