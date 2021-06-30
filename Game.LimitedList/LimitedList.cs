using System;
using System.Collections;
using System.Collections.Generic;

namespace Game.LimitedList

{
    public class LimitedList<T> : IEnumerable<T>
    {
        private int capacity;
        protected List<T> list;

        public int Capacity => capacity;

        public bool IsFull => capacity <= Count;
        public T this[int index] => list[index];

        public int Count => list.Count;

        public LimitedList(int capacity)
        {
            this.capacity = Math.Max(1, capacity);
            list = new List<T>(this.capacity);
        }

        public virtual bool Add(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            if (IsFull) return false;
            list.Add(item);
            return true;
        }

        public bool Remove(T item) => list.Remove(item);

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                //.....
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}