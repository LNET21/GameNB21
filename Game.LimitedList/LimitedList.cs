using System;
using System.Collections.Generic;

namespace Game.LimitedList

{
    public class LimitedList<T>
    {
        private int capacity;
        private List<T> list;

        public int Capacity => capacity;

        public bool IsFull => capacity <= Count;

        public int Count => list.Count;

        public LimitedList(int capacity)
        {
            this.capacity = Math.Max(1, capacity);
            list = new List<T>(this.capacity);
        }

        public bool Add(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            if (IsFull) return false;
            list.Add(item);
            return true;
        }
    }
}