using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 공장 클래스의 최상위 클래스
public abstract class Factory_Ship_Factory
{
    // 하위 클래스들이 공통적으로 가지고 있을 OrderShip메서드
    public Factory_Ship OrderShip()
    {
        // 객체 생성
        Factory_Ship ship = CreateShip();
        // 생성한 객체 반환
        return ship;
    }

    // 하위 클래스에서 정의할 객체 생성 메서드
    public abstract Factory_Ship CreateShip();
}

// 객체의 상위 클래스
public class Factory_Ship
{
    public string name = string.Empty;
    public string color = string.Empty;
    public string capacity = string.Empty;

    public override string ToString()
    {
        return $"Ship {{Name : {name}, Color : {color}, Capacity : {capacity}";
    }
}

// 객체A
public class Factory_Ship_A : Factory_Ship
{
    public Factory_Ship_A(string name, string color, string capacity)
    {
        this.name = name;
        this.color = color;
        this.capacity = capacity;
    }
}

// 객체A의 공장 클래스
public class Factory_Ship_A_Factory : Factory_Ship_Factory
{
    // CreateShip을 오버라이드하여 메서드 구현
    public override Factory_Ship CreateShip()
    {
        return new Factory_Ship_A("ShipA", "Red", "20t");
    }
}

// 객체B
public class Factory_Ship_B : Factory_Ship
{
    public Factory_Ship_B(string name, string color, string capacity)
    {
        this.name = name;
        this.color = color;
        this.capacity = capacity;
    }
}

// 객체B의 공장 클래스
public class Factory_Ship_B_Factory : Factory_Ship_Factory
{
    // CreateShip을 오버라이드하여 메서드 구현
    public override Factory_Ship CreateShip()
    {
        return new Factory_Ship_B("ShipB", "Blue", "15t");
    }
}