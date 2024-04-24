using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Strategy_Run : Strategy_IMove
{
    public void Move()
    {
        Console.WriteLine("Run");
    }
}
