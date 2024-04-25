using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ISortEngine
{
    public abstract void SetList();
    public abstract void Sort();
    public abstract void ReverseSort();
    public abstract void PrintSortList();
}

// 클라이언트가 정렬 알고리즘을 사용
public class SortingMachine
{
    ISortEngine sortEngine;

    public void SetSortEngine(ISortEngine sortEngine)
    {
        this.sortEngine = sortEngine;
    }

    public void Sorting()
    {
        if (sortEngine == null)
        {
            return;
        }
        sortEngine.SetList();
        sortEngine.Sort();

        sortEngine.PrintSortList();
        sortEngine.ReverseSort();

        sortEngine.PrintSortList();
    }

}

// 기존에 사용중이던 정렬 엔진
public class A_SortEngine : ISortEngine
{
    public void PrintSortList()
    {
        Console.WriteLine("A_SortEngine PrintSortList");
    }

    public void ReverseSort()
    {
        Console.WriteLine("A_SortEngine ReverseSort");
    }

    public void SetList()
    {
        Console.WriteLine("A_SortEngine SetList");
    }

    public void Sort()
    {
        Console.WriteLine("A_SortEngine Sort");
    }
}

// 새로 사용할 정렬 엔진
public class B_SortEngine
{
    // 이전 보다 성능이 좋은 리스트 세팅과 정렬 메소드
    public void SetList()
    {
        Console.WriteLine("B_SortEngine SetList");
    }
    public void Sorting(bool isRevers)
    {
        Console.WriteLine("B_SortEngine Sorting, isRevers : {0}", isRevers);
    }
}

public class SortEngineAdaptor : ISortEngine
{
    A_SortEngine AEngine;
    B_SortEngine BEngine;

    public SortEngineAdaptor(A_SortEngine aEngine, B_SortEngine bEngine)
    {
        AEngine = aEngine;
        BEngine = bEngine;
    }

    // B엔진에는 리스트을 출력하는 메서드가 없기 대문에
    // A엔진에 있는 출력 메서드를 사용
    public void PrintSortList()
    {
        AEngine.PrintSortList();
    }

    // B엔진은 A엔진 보다 좋은 성능을 가진
    // 정렬, 리스트 지정 메서드가 있기때문에 B엔진의 메서드 사용
    public void ReverseSort()
    {
        BEngine.Sorting(true);
    }

    public void SetList()
    {
        BEngine.SetList();
    }

    public void Sort()
    {
        BEngine.Sorting(false);
    }
}