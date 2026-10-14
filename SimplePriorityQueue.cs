using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp
{
    public class SimplePriorityQueue<T>
    {
        private readonly SortedDictionary<int, Queue<T>> _buckets =
            new SortedDictionary<int, Queue<T>>();

        public int Count { get; private set; }

        public void Enqueue(T item, int priority)
        {
            if (!_buckets.ContainsKey(priority))
                _buckets[priority] = new Queue<T>();

            _buckets[priority].Enqueue(item);
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException("Priority queue is empty.");

            var first = _buckets.First();
            T item = first.Value.Dequeue();

            if (first.Value.Count == 0)
                _buckets.Remove(first.Key);

            Count--;
            return item;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Priority queue is empty.");

            return _buckets.First().Value.Peek();
        }

        public IEnumerable<T> GetAllOrdered()
        {
            foreach (var bucket in _buckets)
                foreach (T item in bucket.Value)
                    yield return item;
        }

        public void Clear()
        {
            _buckets.Clear();
            Count = 0;
        }
    }
}