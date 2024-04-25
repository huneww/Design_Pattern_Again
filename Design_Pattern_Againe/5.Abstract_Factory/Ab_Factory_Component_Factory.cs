using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Ab_Factory_Component_Factory
{
    public abstract Ab_Factory_Button CreateButton();
    public abstract Ab_Factory_CheckBox CreateCheckBox();
    public abstract Ab_Factory_Text CreateText();
}

