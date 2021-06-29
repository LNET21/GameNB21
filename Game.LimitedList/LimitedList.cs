using System;
using System.Collections.Generic;

namespace Game.LimitedList

{
    public class LimitedList<T>
    {
        private int capacity;
        private List<T> list;

        public int Capacity => capacity;

        public bool IsFull { get; set; }

        public LimitedList(int capacity)
        {
            this.capacity = Math.Max(1, capacity);
            list = new List<T>(this.capacity);
        }

        public bool Add(int v)
        {
            throw new NotImplementedException();
        }
    }
}