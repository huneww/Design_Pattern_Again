using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Strategy_Robot
{
    Strategy_IMove move;
    Strategy_ITranslate translate;

    public Strategy_Robot (Strategy_IMove move, Strategy_ITranslate translate)
    {
        this.move = move;
        this.translate = translate;
    }

    public void Move()
    {
        move.Move();
    }

    public void Translate()
    {
        translate.Translate();
    }

    public void SetMove(Strategy_IMove move)
    {
        this.move = move;
    }

    public void SetTranslate(Strategy_ITranslate translate)
    {
        this.translate = translate;
    }

}
