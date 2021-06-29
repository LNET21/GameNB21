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
                case ConsoleKey.P:
                    PickUp();
                    break;
                case ConsoleKey.I:
                    Inventory();
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }

        private void Inventory()
        {
            foreach (var item in hero.BackBack)
            {
                Console.WriteLine(item);
            }
        }

        private void PickUp()
        {
            throw new NotImplementedException();
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
            UI.Draw(map);
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


            //ToDo random positions
            map.GetCell(4, 6).Items.Add(Item.Coin());
            map.GetCell(2, 8).Items.Add(Item.Coin());
            map.GetCell(9, 3).Items.Add(Item.Stone());
        }
    }
}