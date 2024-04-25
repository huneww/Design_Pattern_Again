using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ab_Factory_Window : Ab_Factory_Component_Factory
{
    private static Ab_Factory_Window instance;
    public static Ab_Factory_Window Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Ab_Factory_Window();
            }

            return instance;
        }
    }

    public override Ab_Factory_Button CreateButton()
    {
        Ab_Factory_Button button = new Ab_Factory_Button_Window();
        button.Render();
        return button;
    }

    public override Ab_Factory_CheckBox CreateCheckBox()
    {
        Ab_Factory_CheckBox_Window checkBox = new Ab_Factory_CheckBox_Window();
        checkBox.Render();
        return checkBox;
    }

    public override Ab_Factory_Text CreateText()
    {
        Ab_Factory_Text_Window text = new Ab_Factory_Text_Window();
        text.Render();
        return text;
    }
}

public class Ab_Factory_Button_Window : Ab_Factory_Button
{
    public override void Render()
    {
        Console.WriteLine("Window Button");
    }
}

public class Ab_Factory_CheckBox_Window : Ab_Factory_CheckBox
{
    public override void Render()
    {
        Console.WriteLine("Window CheckBox");
    }
}

public class Ab_Factory_Text_Window : Ab_Factory_Text
{
    public override void Render()
    {
        Console.WriteLine("Window Text");
    }
}