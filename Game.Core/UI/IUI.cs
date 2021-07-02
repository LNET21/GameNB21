using Game.Core.GameWorld.Interfaces;
using System;

namespace Game.Core.UI
{
    public interface IUI
    {
        void AddMessage(string message);
        void Clear();
        void Draw();
        ConsoleKey GetKey();
        void PrintStats(string stats);
        void PrintLog();
    }
}