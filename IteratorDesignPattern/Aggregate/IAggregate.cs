using IteratorDesignPattern.Iterator;
namespace IteratorDesignPattern.Aggregate;
public interface IAggregate<T>
{
    T this[int index] { get; set; }
    int Count { get; }
    IIterator<T> Iterator { get; }
}