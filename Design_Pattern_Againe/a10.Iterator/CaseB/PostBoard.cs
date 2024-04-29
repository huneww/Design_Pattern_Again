using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ITERATORTYPE
{
    A,
    B,
}

// 반복자의 상위 인터페이스
public interface IITerator<T>
{
    bool HasNext();
    T Next();
}

// 컬렉션의 상위 인터페이스
public interface IAggregate<T>
{
    IITerator<T> CreateIterator(ITERATORTYPE type);
}

public class MyAggregate<T> : IAggregate<T>
{
    private List<T> items = new List<T>();

    public IITerator<T> CreateIterator(ITERATORTYPE type)
    {
        IITerator<T> iterator = new MyIterator1<T>(this);
        switch (type)
        {
            case ITERATORTYPE.A:
                iterator = new MyIterator1<T>(this);
                break;
            case ITERATORTYPE.B:
                iterator = new MyIterator2<T>(this);
                break;
        }

        return iterator;
    }

    public int Count
    {
        get
        {
            return items.Count;
        }
    }

    public T this[int index]
    {
        get
        {
            return items[index];
        }
        set
        {
            items.Insert(index, value);
        }
    }

}

public class MyIterator1<T> : IITerator<T>
{
    private MyAggregate<T> aggregate;
    private int curIndex = 0;

    public MyIterator1(MyAggregate<T> aggregate)
    {
        this.aggregate = aggregate;
    }

    public bool HasNext()
    {
        return curIndex < aggregate.Count;
    }

    public T Next()
    {
        // 순환 알고리즘 제작
        if (!HasNext())
        {

        }

        return aggregate[curIndex++];
    }
}

public class MyIterator2<T> : IITerator<T>
{
    private MyAggregate<T> aggregate;
    private int curIndex = 0;

    public MyIterator2(MyAggregate<T> aggregate)
    {
        this.aggregate = aggregate;
    }

    public bool HasNext()
    {
        return curIndex < aggregate.Count;
    }

    public T Next()
    {
        // 순환 알고리즘 제작
        if (!HasNext())
        {

        }

        return aggregate[curIndex++];
    }

}