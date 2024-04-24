using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class State_Test_Player
{
    State_Test_Base state;

    public State_Test_Player(State_Test_Base state)
    {
        this.state = state;
    }

    public void SetState(State_Test_Base state)
    {
        this.state = state;
    }

    public void Action()
    {
        state.StateAction(this);
    }

}

public abstract class State_Test_Base
{
    public abstract void StateAction(State_Test_Player player);
}

public class State_Test_State_A : State_Test_Base
{
    public override void StateAction(State_Test_Player player)
    {
        Console.WriteLine("State_A_Action");
    }
}

public class State_Test_State_B : State_Test_Base
{
    public override void StateAction(State_Test_Player player)
    {
        Console.WriteLine("State_B_Action");
    }
}

public class State_Test_State_C : State_Test_Base
{
    public override void StateAction(State_Test_Player player)
    {
        Console.WriteLine("State_C_Action");
        Console.WriteLine("Change State_C to State_B");
        player.SetState(new State_Test_State_B());
    }
}