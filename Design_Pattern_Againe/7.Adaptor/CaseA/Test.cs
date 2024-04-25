using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클라이언트가 사용하고 자하는 기존에 서브스하던 기능(호환이 안되서 사용이 불가능)
public class Test_Service
{
    public void TestServiceMethod(int customData)
    {
        Console.WriteLine("기존 서비스 기능 호출 : {0}", customData);
    }
}

// 클라이언트가 접근하여 사용할 상위 클래스
public interface Test_New_Service
{
    public abstract void Method(int data);
}

public class Test_Adaptor : Test_New_Service
{
    // 호환이 되지 않았던 기존 서비스
    Test_Service adaptor;

    public Test_Adaptor(Test_Service adaptor)
    {
        this.adaptor = adaptor;
    }

    // 클라이언트가 기존 서비스를 호출하는 메서드
    public void Method(int data)
    {
        Console.WriteLine("새로운 서비스");
        adaptor.TestServiceMethod(data);
    }
}

// 상속을 통해 기존 서비스에 접근
public class Test_Adaptor2 : Test_Service, Test_New_Service
{
    public void Method(int data)
    {
        TestServiceMethod(data);
    }
}
