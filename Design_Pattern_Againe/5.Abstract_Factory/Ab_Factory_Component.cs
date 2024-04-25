using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Ab_Factory_Component
{
    public abstract void Render();
}

public abstract class Ab_Factory_Button : Ab_Factory_Component
{
    public abstract void Render();
}

public abstract class Ab_Factory_CheckBox : Ab_Factory_Component
{
    public abstract void Render();
}

public abstract class Ab_Factory_Text : Ab_Factory_Component
{
    public abstract void Render();
}