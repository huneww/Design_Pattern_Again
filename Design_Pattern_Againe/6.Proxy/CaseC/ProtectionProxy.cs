using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 직책 열거문
public enum POSITION
{
    STAFF,
    MANAGER,
    DIRECTOR,
}

#region 좋지 않은 코드
// 구성원 클래스
public class Bad_Employee
{
    private string name;        // 이름
    private POSITION position;  // 직책

    public Bad_Employee(string name, POSITION position)
    {
        this.name = name;
        this.position = position;
    }

    public string GetName()
    {
        return name;
    }

    public POSITION GetPosition()
    {
        return position;
    }

    public override string ToString()
    {
        return $"Display {GetPosition()} : {GetName()}, personel information";
    }

}

public class Bad_PrintEmployeeInfo
{
    private Bad_Employee viewr;

    public Bad_PrintEmployeeInfo(Bad_Employee viewer)
    {
        this.viewr = viewer;
    }

    public void PrintAllInfo(List<Bad_Employee> list)
    {
        foreach (Bad_Employee e in list)
        {
            Console.WriteLine(e.ToString());
        }
    }

}
#endregion

// 구성원 인터페이스
public interface IEmployee
{
    // 구성원 이름 획득
    public abstract string GetName();
    // 구성원 직책 획득
    public abstract POSITION GetPosition();
    // 구성원 정보 획득
    public abstract string GetInfo(IEmployee viewer);
}

// 기본적인 사원의 정보 클래스
public class Employee : IEmployee
{
    // 사원의 이름
    private string name;
    // 사원의 직책
    private POSITION position;

    public Employee(string name, POSITION position)
    {
        this.name = name;
        this.position = position;
    }

    public string GetName()
    {
        return name;
    }

    public POSITION GetPosition()
    {
        return position;
    }

    public string GetInfo(IEmployee viewer)
    {
        return $"Display {GetPosition()} : {GetName()}, personnel infomation";
    }
}

// 사원들의 정보를 출력하는 클래스
public class PrintEmployeeInfo
{
    // 사원의 정보를 출력하려는 사람
    private IEmployee viewer;

    public PrintEmployeeInfo(IEmployee viewer)
    {
        this.viewer = viewer;
    }

    // 사원들의 정보를 출력
    public void printAllInfo(List<IEmployee> list)
    {
        foreach (IEmployee e in list)
        {
            // 각 ProtectedEmployy의 GetInfo로 정보를 조회가능한지 확인
            Console.WriteLine(e.GetInfo(viewer));
        }
    }

}

// 정보를 보호 받을 사원들의 클래스
public class ProtectedEmployee : IEmployee
{
    // 사원의 정보
    private IEmployee employee;

    public ProtectedEmployee(IEmployee employee)
    {
        this.employee = employee;
    }

    // 사원의 정보를 반환
    public string GetInfo(IEmployee viewer)
    {
        // 현재 사원의 직책을 획득
        POSITION position = employee.GetPosition();

        string answer = "정보를 조회 할수 없음";

        // 정보를 출력하려는 사람의 직책에 따라 반환값 변경
        switch (viewer.GetPosition())
        {
            // 출력하려는 사람의 직책이 디렉터라면
            case POSITION.DIRECTOR:
                // 모든 인원의 정보를 출력
                answer = employee.GetInfo(viewer);
                break;
            // 출력하려는 사람의 직책이 매니저라면
            case POSITION.MANAGER:
                // 디렉터를 제외한 인원의 정보를 출력
                if (position != POSITION.DIRECTOR)
                {
                    answer = employee.GetInfo(viewer);
                }
                break;
            // 출력하려는 사람의 직책이 스테프라면
            case POSITION.STAFF:
                // 디렉터, 매니저를 제외한 인원의 정보를 출력
                if (position != POSITION.DIRECTOR && position != POSITION.MANAGER)
                {
                    answer = employee.GetInfo(viewer);
                }
                break;
        }
        return answer;
    }

    public string GetName()
    {
        return employee.GetName();
    }

    public POSITION GetPosition()
    {
        return employee.GetPosition();
    }
}
