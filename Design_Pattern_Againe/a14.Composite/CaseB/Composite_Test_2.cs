using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ItemComponent
{
    string GetName();
    int GetPrice();
}

// Composite객체 클래스
public class Bag : ItemComponent
{
    List<ItemComponent> items = new List<ItemComponent>();

    string name;

    public Bag(string name)
    {
        this.name = name;
    }

    public void Add(ItemComponent item)
    {
        items.Add(item);
    }

    public void Remove(ItemComponent item)
    {
        items.Remove(item);
    }

    public List<ItemComponent> GetItems()
    {
        return items;
    }

    public string GetName()
    {
        return name;
    }

    public int GetPrice()
    {
        int sum = 0;

        foreach (var item in items)
        {
            sum += item.GetPrice();
        }

        return sum;
    }
}

// Leaf객체의 클래스
public class Item : ItemComponent
{
    string name;
    int price;

    public Item(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName()
    {
        return name;
    }

    public int GetPrice()
    {
        return price;
    }
}