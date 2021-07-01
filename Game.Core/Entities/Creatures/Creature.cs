using Game.Core.GameWorld;
using Game.Core.GameWorld.Interfaces;
using System;

namespace Game.Core.Entities.Creatures
{
    public abstract class Creature : IDrawable
    {
        private int health;
        private ConsoleColor color;
        private string name => this.GetType().Name;

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
        public ConsoleColor Color 
        {
            get => IsDead ? ConsoleColor.Gray : color;
            set => color = value;
        } 
        public Cell Cell { get; set; }

        public Action<string> AddMessage { get; set; }

        public Creature(Cell cell, string symbol, int maxHealth)
        {
            Cell = cell;
            Symbol = symbol;
            MaxHealth = maxHealth;
            health = maxHealth;
            Color = ConsoleColor.Green;
        }

        public void Attack(Creature target)
        {
            if (target.IsDead) return;

            var thisName = this.name;
            var targetName = target.name;

            target.Health -= Damage;
            AddMessage?.Invoke($"The {thisName} attacks the {targetName} for {this.Damage}");

            if (target.IsDead)
            {
                AddMessage?.Invoke($"The {targetName} is dead");
                return;
            }

            Health -= target.Damage;
            AddMessage?.Invoke($"The {targetName} attacks the {thisName} for {target.Damage}");

            if (IsDead)
            {
                AddMessage?.Invoke($"The {thisName} is dead");
                return;
            }

        }
    }
}