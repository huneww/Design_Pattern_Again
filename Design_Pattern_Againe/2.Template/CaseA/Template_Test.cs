using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상위 클래스
public abstract class Template_Test_Base
{
    // 하위 클래스들이 공통적으로 가지고 있을 메소드
    // 가상 메서드로 선언하여 알고리즘 추가에 용이하도록 설정
    public virtual void TemplateMethods()
    {
        Step1();
        Step2();
        if (Hook())
        {
            Step3();
        }
        Step4();
    }

    // 특정 단계는 일정 패턴일때만 실행 시킬수 있도록 패턴 확인 메서드
    public virtual bool Hook()
    {
        return false;
    }

    // 알고리즘의 단계
    // 가상 메서드로 선언하여 변경에 용이하도록 설정
    public virtual void Step1()
    {
        Console.WriteLine("Test_Base_Step1");
    }
    public virtual void Step2()
    {
        Console.WriteLine("Test_Base_Step2");
    }
    public virtual void Step3()
    {
        Console.WriteLine("Test_Base_Step3");
    }
    public virtual void Step4()
    {
        Console.WriteLine("Test_Base_Step4");
    }
}

public class Template_Test_A : Template_Test_Base
{
    public override void Step1()
    {
        Console.WriteLine("Test_A_Step1");
    }

    public override void Step2()
    {
        Console.WriteLine("Test_A_Step2");
    }

    public override void Step3()
    {
        Console.WriteLine("Test_A_Step3");
    }

    public override void Step4()
    {
        Console.WriteLine("Test_A_Step4");
    }
}

public class Template_Test_B : Template_Test_Base
{
    public override void Step1()
    {
        Console.WriteLine("Test_B_Step1");
    }

    public override void Step2()
    {
        Console.WriteLine("Test_B_Step2");
    }

    public override void Step3()
    {
        Console.WriteLine("Test_B_Step3");
    }

    public override void Step4()
    {
        Console.WriteLine("Test_B_Step4");
    }

    // Hook메서드 변경
    public override bool Hook()
    {
        return true;
    }
}

public class Template_Test_C : Template_Test_Base
{
    // TemplateMethods를 변경
    public override void TemplateMethods()
    {
        base.TemplateMethods();
        Step6();
    }

    // 추가 알고리즘 단계
    public void Step6()
    {
        Console.WriteLine("Test_C_Step6");
    }
}