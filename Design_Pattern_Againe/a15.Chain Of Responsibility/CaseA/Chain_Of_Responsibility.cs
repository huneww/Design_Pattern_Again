using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

public class GameObject
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
}

public class Character : GameObject
{
    public Character(string name)
    {
        base.Name = name;
    }
}

public class UI : GameObject
{
    public UI(string name)
    {
        base.Name = name;
    }
}

public interface IEventHandler
{
    IEventHandler SetNext(IEventHandler handler);
    void HandleEvent(string eventType, GameObject target);
}

public abstract class BaseEventHandler : IEventHandler
{
    IEventHandler nextEvent;

    public virtual void HandleEvent(string eventType, GameObject target)
    {
        if (nextEvent != null)
        {
            nextEvent.HandleEvent(eventType, target);
        }
        else
        {
            Console.WriteLine("이벤트를 처리할 수 있는 핸들러가 없음");
        }
    }

    public IEventHandler SetNext(IEventHandler handler)
    {
        nextEvent = handler;
        return handler;
    }
}

public class CharacterEventHandler : BaseEventHandler
{
    public override void HandleEvent(string eventType, GameObject target)
    {
        if (eventType == "MouseClick" && target is Character)
        {
            Console.WriteLine("캐릭터 클릭");
        }
        else if (eventType == "MouseClick2" && target is Character)
        {
            Console.WriteLine("캐릭터 클릭2");
        }
        else
        {
            Console.WriteLine("Pass");
            base.HandleEvent(eventType, target);
        }
    }
}

public class UIEventHandler : BaseEventHandler
{
    public override void HandleEvent(string eventType, GameObject target)
    {
        if (eventType == "MouseClick" && target is UI)
        {
            Console.WriteLine("UI 클릭");
        }
        else
        {
            Console.WriteLine("Pass");
            base.HandleEvent(eventType, target);
        }
    }
}