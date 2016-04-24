using IteratorPattern.Iterator;
using System.Collections.Generic;

namespace IteratorPattern.Aggregate
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();

        List<T> GetAll();

        void AddItem(T item);
    }
}