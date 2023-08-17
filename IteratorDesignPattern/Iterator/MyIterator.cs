using IteratorDesignPattern.Aggregate;

namespace IteratorDesignPattern.Iterator;
public class MyIterator<T> : IIterator<T>
{
    private readonly IAggregate<T> _aggregate;
    int Index = 0 ;
   
    public MyIterator(IAggregate<T> aggregate)
    {
        _aggregate = aggregate;
    }

    public bool HasNext()
    {
        return Index <  _aggregate.Count;
    }

    public T MoveNext()
    {
        return !HasNext() ? default : _aggregate[Index++];
    }

   
}
