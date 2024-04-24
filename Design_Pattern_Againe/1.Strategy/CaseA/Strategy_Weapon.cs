using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 무기들의 상위 클래스
public interface Strategy_IWeapon
{
    // 무기 액션 출력 메서드
    public abstract Strategy_IWeapon WeaponAction();
    // 무기 정보 출력 메서드
    public abstract Strategy_IWeapon WeaponInfo();
}

// 무기 정보 클래스
public class Weapon_Info
{
    private string name = string.Empty;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    private string damage = string.Empty;
    public string Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    private string actionCoolDown = string.Empty;
    public string ActionCoolDown
    {
        get
        {
            return actionCoolDown;
        }
        set
        {
            actionCoolDown = value;
        }
    }

    public Weapon_Info(string name, string damage, string actionCoolDown)
    {
        this.name = name;
        this.damage = damage;
        this.actionCoolDown = actionCoolDown;
    }

    public void SetInfo(string name, string damage, string actionCoolDown)
    {
        this.name = name;
        this.damage = damage;
        this.actionCoolDown = actionCoolDown;
    }

    public override string ToString()
    {
        return $"name : {name}, damage : {damage}, actionCoolDown : {actionCoolDown}";
    }

}

public class Strategy_Sword : Strategy_IWeapon
{
    // 무기 정보 변수
    Weapon_Info weapon;
    
    // 무기 정보 저장
    public Strategy_Sword(Weapon_Info weapon)
    {
        this.weapon = weapon;
    }

    // 무기 액션 출력
    public Strategy_IWeapon WeaponAction()
    {
        Console.WriteLine("Sword Action");

        return this;
    }

    // 무기 정보 출력
    public Strategy_IWeapon WeaponInfo()
    {
        Console.WriteLine(weapon.ToString());

        return this;
    }

}

public class Strategy_Shield : Strategy_IWeapon
{
    // 무기 정보 변수
    Weapon_Info weapon;

    // 무기 정보 저장
    public Strategy_Shield(Weapon_Info weapon)
    {
        this.weapon = weapon;
    }

    // 무기 액션 출력
    public Strategy_IWeapon WeaponAction()
    {
        Console.WriteLine("Shield Action");

        return this;
    }

    // 무기 정보 출력
    public Strategy_IWeapon WeaponInfo()
    {
        Console.WriteLine(weapon.ToString());

        return this;
    }

}

public class Strategy_CrossBow : Strategy_IWeapon
{
    // 무기 정보 변수
    Weapon_Info weapon;

    // 무기 정보 저장
    public Strategy_CrossBow(Weapon_Info weapon)
    {
        this.weapon = weapon;
    }

    // 무기 액션 출력
    public Strategy_IWeapon WeaponAction()
    {
        Console.WriteLine("Cross Bow Action");

        return this;
    }

    // 무기 정보 출력
    public Strategy_IWeapon WeaponInfo()
    {
        Console.WriteLine(weapon.ToString());

        return this;
    }

}
