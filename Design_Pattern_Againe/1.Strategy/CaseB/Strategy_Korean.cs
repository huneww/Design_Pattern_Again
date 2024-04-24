using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Strategy_Korean : Strategy_ITranslate
{
    public void Translate()
    {
        Console.WriteLine("Korean");
    }
}
