using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 데이터 집합
interface Aggregate
{
    Iterator iterator();
}

class ConcreteAggregate : Aggregate
{
    // 데이터 집합
    object[] arr;
    int index = 0;

    public ConcreteAggregate(int size)
    {
        this.arr = new object[size];
    }

    public void Add(object item)
    {
        if (index < arr.Length)
        {
            arr[index] = item;
            index++;
        }
    }

    public Iterator iterator()
    {
        return new ConcreteIterator(arr);
    }
}

// 반복자
interface Iterator
{
    bool hasNext();
    object next();
}

class ConcreteIterator : Iterator
{
    object[] arr;
    private int nextIndex = 0;

    // 생성자로 순회할 배열 저장
    public ConcreteIterator(object[] arr)
    {
        this.arr = arr;
    }

    // 다음 요소가 있는지 확인
    public bool hasNext()
    {
        return nextIndex < arr.Length;
    }

    // 요소를 반환후 다음 요소를 바라보도록 설정
    public object next()
    {
        return arr[nextIndex++];
    }
}