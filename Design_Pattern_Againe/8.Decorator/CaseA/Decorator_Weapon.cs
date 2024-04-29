using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 원본과 장식자를 합칠 상위 인터페이스
public interface IWeapon
{
    public abstract void AimAndFire();
}

// 원본 클래스
public class BaseWeapon : IWeapon
{
    public void AimAndFire()
    {
        Console.WriteLine("Base Weapon Fire");
    }
}

// 장식 클래스
public abstract class WeaponAccessory : IWeapon
{
    private IWeapon baseWeapon;

    public WeaponAccessory(IWeapon baseWeapon)
    {
        this.baseWeapon = baseWeapon;
    }

    public virtual void AimAndFire()
    {
        baseWeapon.AimAndFire();
    }
}

public class Generade : WeaponAccessory
{
    public Generade(IWeapon baseWeapon) : base(baseWeapon)
    {
    }

    public override void AimAndFire()
    {
        GeneradeFire();
        base.AimAndFire();
    }

    public void GeneradeFire()
    {
        Console.WriteLine("Generade Fire");
    }
}

public class Scoped : WeaponAccessory
{
    public Scoped(IWeapon baseWeapon) : base(baseWeapon)
    {
    }

    public override void AimAndFire()
    {
        Aiming();
        base.AimAndFire();
    }

    public void Aiming()
    {
        Console.WriteLine("Aiming...");
    }
}

public class ButtStock : WeaponAccessory
{
    public ButtStock(IWeapon baseWeapon) : base(baseWeapon)
    {
    }

    public override void AimAndFire()
    {
        Holding();
        base.AimAndFire();
    }

    public void Holding()
    {
        Console.WriteLine("Weapon holding");
    }
}