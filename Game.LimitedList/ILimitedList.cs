using System;
using System.Collections.Generic;

namespace Game.LimitedList
{
    public interface ILimitedList<T> : IEnumerable<T>
    {
        T this[int index] { get; }

        int Capacity { get; }
        int Count { get; }
        bool IsFull { get; }

        void ActionOutputAll(Action<T> action);
        bool Add(T item);
        bool Remove(T item);
    }
}