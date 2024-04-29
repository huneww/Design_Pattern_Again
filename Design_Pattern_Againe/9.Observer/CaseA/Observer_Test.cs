using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 옵저버의 발행자가 상속받을 상위 클래스
public interface Observer_ISubject
{
    public abstract void AddObserver(MyIObserver ob);
    public abstract void RemoveObserver(MyIObserver ob);
    public abstract void NotifyObserver();
}

// 발행자
public class ConcreteSubject : Observer_ISubject
{
    // 상태 변경시 호출할 관찰자
    List<MyIObserver> observers = new List<MyIObserver>();

    // 관찰자 추가
    public void AddObserver(MyIObserver ob)
    {
        observers.Add(ob);
        Console.WriteLine("Add : " + ob);
    }

    // 관찰자 제거
    public void RemoveObserver(MyIObserver ob)
    {
        observers.Remove(ob);
        Console.WriteLine("Remove : " + ob);
    }

    // 상태 변경시 관찰자 전원 호출
    public void NotifyObserver()
    {
        foreach (var ob in observers)
        {
            Console.WriteLine("Info : " + ob);
        }
    }
}

// 관찰자가 상속받을 인터페이스
public interface MyIObserver
{
    public abstract void Update();
}

// 관찰자
public class ObserverA : MyIObserver
{
    public void Update()
    {
        Console.WriteLine("ObserverA Get Update");
    }

    public override string ToString()
    {
        return "ObserverA";
    }
}

// 관찰자
public class ObserverB : MyIObserver
{
    public void Update()
    {
        Console.WriteLine("ObserverB Get Update");
    }

    public override string ToString()
    {
        return "ObserverB";
    }
}
