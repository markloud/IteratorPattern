
namespace IteratorPattern.Iterator
{
    public interface IIterator<T>
    {
        T First();
        T Next();
        T CurrentItem();
        bool IsDone();
        void AddItem(T item);
    }
}
