using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public interface IAttack
{
    public abstract void Attack();
}

public class PlayerAttack : IAttack
{
    public void Attack()
    {
        Console.WriteLine("Default Attack");
    }
}

public abstract class PlayerAttackEvent : IAttack
{
    private IAttack attack;

    public PlayerAttackEvent(IAttack attack)
    {
        this.attack = attack;
    }

    public virtual void Attack()
    {
        attack.Attack();
    }

    public IAttack GetInnerAttack()
    {
        return attack;
    }
}

public class PlayerAttackPassive : PlayerAttackEvent
{
    private double passive;
    
    public PlayerAttackPassive(double passive, IAttack attack) : base(attack)
    {
        this.passive = passive;
    }

    public override void Attack()
    {
        base.Attack();
        Passive();
    }

    public void Passive()
    {
        Console.WriteLine(passive);
    }
}

public class PlayerAttackSkill : PlayerAttackEvent
{
    private string skill;

    public PlayerAttackSkill(string skill, IAttack attack) : base(attack)
    {
        this.skill = skill;
    }

    public override void Attack()
    {
        base.Attack();
        Skill();
    }

    public void Skill()
    {
        Console.WriteLine(skill);
    }

}
