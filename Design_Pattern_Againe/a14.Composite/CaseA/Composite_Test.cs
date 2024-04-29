

public interface IComposite_Test
{
    public void Operation();
}

public class Leaf : IComposite_Test
{
    public void Operation()
    {
        Console.WriteLine(this + "Call");
    }
}

public class Composite : IComposite_Test
{
    List<IComposite_Test> leafs = new List<IComposite_Test>();

    public void AddLeaf(IComposite_Test component)
    {
        leafs.Add(component);
    }

    public void Remove(IComposite_Test component)
    {
        leafs.Remove(component);
    }

    public void Operation()
    {
        // 자기 자신을 호출
        Console.WriteLine(this + "Call");

        // 리스트에 있는 묶음들 호출
        foreach (var item in leafs)
        {
            item.Operation();
        }
    }

    public List<IComposite_Test> Getchild()
    {
        return leafs;
    }
}
