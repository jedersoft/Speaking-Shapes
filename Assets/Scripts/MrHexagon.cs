using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrHexagon : Character //INHERITANCE
{
    public override void Greet() //POLYMORPHISM
    {
        Talk("...uhm, hi..." + GameManager.Instance.playerName + " was your name right? Uhm. I'm " + Name + " and I'm a bit lazy...");
    }

    public override void SayGoodbye()
    {
        Talk("Oh...uhm...bye.");
    }

    protected override void DemandFood()
    {
        Talk("I'm a bit bored...can you give me some food?");
    }

    protected override void DemandNothing()
    {
        Talk("Uhm...I don't know, I think not.");
    }

    protected override void DemandSleep()
    {
        Talk("I'm getting tired. When can I go home?");
    }

    protected override void DemandSpecial()
    {
        Talk("Standing is exhausting, can I sit down please?");
    }
}
