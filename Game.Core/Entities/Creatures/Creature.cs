using Game.Core.GameWorld;
using Game.Core.GameWorld.Interfaces;
using System;

namespace Game.Core.Entities.Creatures
{
    abstract class Creature : IDrawable
    {
        private int health;

        public int Health
        {
            get => health < 0 ? 0 : health;
            set 
            {
                health = value >= MaxHealth ? MaxHealth : value;
            }
        }

        public int MaxHealth { get; private set; }

        public int Damage { get; set; } = 50;

        public bool IsDead => health <= 0;


        public string Symbol { get; set; }
        public ConsoleColor Color { get; set; } = ConsoleColor.Green;
        public Cell Cell { get; set; }

        public Creature(Cell cell, string symbol, int maxHealth)
        {
            Cell = cell;
            Symbol = symbol;
            MaxHealth = maxHealth;
            health = maxHealth;
        }
    }
}