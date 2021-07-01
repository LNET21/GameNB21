using Game.Core.GameWorld.Interfaces;
using System;

namespace Game.Core.Entities.Items
{
    public class Item : IDrawable
    {
        private readonly string name;

        public ConsoleColor Color { get; set; }
        public string Symbol { get; }

        public Item(string symbol, ConsoleColor color, string name)
        {
            Symbol = symbol;
            Color = color;
            this.name = name;
        }

        public override string ToString() => name;


        public static Item Coin() => new Item("c ", ConsoleColor.Yellow, "Coin");
        public static Item Stone() => new Item("s ", ConsoleColor.Gray, "Stone");
    }
}