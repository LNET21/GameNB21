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
                    Move(Direction.West);
                    break;
                case ConsoleKey.RightArrow:
                    Move(Direction.East);
                    break;
                case ConsoleKey.UpArrow:
                    Move(Direction.North);
                    break;
                case ConsoleKey.DownArrow:
                    Move(Direction.South);
                    break;
                default:
                    break;
            }
        }

        private void Move(Position movement)
        {
            Position newPosition = hero.Cell.Position + movement;
            Cell newCell = map.GetCell(newPosition);

            if (newCell != null) hero.Cell = newCell;
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

                    drawable = map.Creatures.CreatureAtExtension(cell) ?? cell;

                    Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White;
                    Console.Write(drawable?.Symbol);
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