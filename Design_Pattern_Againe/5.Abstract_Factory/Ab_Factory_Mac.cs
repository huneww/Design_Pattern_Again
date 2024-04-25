using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ab_Factory_Mac : Ab_Factory_Component_Factory
{
    private static Ab_Factory_Mac instance;
    public static Ab_Factory_Mac Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Ab_Factory_Mac();
            }

            return instance;
        }
    }

    public override Ab_Factory_Button CreateButton()
    {
        Ab_Factory_Button_Mac button = new Ab_Factory_Button_Mac();
        button.Render();
        return button;
    }

    public override Ab_Factory_CheckBox CreateCheckBox()
    {
        Ab_Factory_CheckBox_Mac checkBox = new Ab_Factory_CheckBox_Mac();
        checkBox.Render();
        return checkBox;
    }

    public override Ab_Factory_Text CreateText()
    {
        Ab_Factory_Text_Mac text = new Ab_Factory_Text_Mac();
        text.Render();
        return text;
    }
}

public class Ab_Factory_Button_Mac : Ab_Factory_Button
{
    public override void Render()
    {
        Console.WriteLine("Mac Button");
    }
}

public class Ab_Factory_CheckBox_Mac : Ab_Factory_CheckBox
{
    public override void Render()
    {
        Console.WriteLine("Mac CheckBox");
    }
}

public class Ab_Factory_Text_Mac : Ab_Factory_Text
{
    public override void Render()
    {
        Console.WriteLine("Mac Text");
    }
}
