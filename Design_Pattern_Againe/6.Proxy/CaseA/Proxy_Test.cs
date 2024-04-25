using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ISubject
{
    abstract void Action();
}

public class RealSubject : ISubject
{
    public void Action()
    {
        Console.WriteLine("Original Subject");
    }
}

// 기본적인 프록시 패턴
public class Normal_Proxy : ISubject
{
    // 수행할 원본 작업
    RealSubject original;

    public Normal_Proxy(RealSubject original)
    {
        this.original = original;
    }

    public void Action()
    {
        original.Action();
        Console.WriteLine("Proxy Subject");
    }
}

// 지연 초기화 방식
// 가끔 필요하지만 항상 적재되어 있는 무거운 객체
// 구현시 자원 소모가 많이 되지만 자주 필요하지 않은 객채
public class Virtual_Proxy : ISubject
{
    private RealSubject original;
     
    public void Action()
    {
        if (original == null)
        {
            original = new RealSubject();
        }

        original.Action();
        Console.WriteLine("Virtual Proxy Subject");
    }
}

// 대상 객체에 대한 엑세스 제한
// 특정 클라이언트만 접근할수 있도록 설정
public class Protection_Proxy : ISubject
{
    private RealSubject subject;
    bool access;

    public Protection_Proxy(RealSubject subject, bool access)
    {
        this.subject = subject;
        this.access = access;
    }

    public void Action()
    {
        if (access)
        {
            subject.Action();
            Console.WriteLine("Protection Proxy Subject");
        }
    }
}

// 대상 객체에 대한 로깅을 추가
public class Logging_Proxy : ISubject
{
    private RealSubject subject;

    public Logging_Proxy(RealSubject subject)
    {
        this.subject = subject;
    }

    public void Action()
    {
        Console.WriteLine("Logging....");
        subject.Action();
        Console.WriteLine("Logging Proxy Subject");
        Console.WriteLine("Logging....");
    }
}