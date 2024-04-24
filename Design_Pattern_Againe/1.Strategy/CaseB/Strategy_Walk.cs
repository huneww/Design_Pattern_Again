using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Strategy_Walk : Strategy_IMove
{
    public void Move()
    {
        Console.WriteLine("Walk");
    }
}
