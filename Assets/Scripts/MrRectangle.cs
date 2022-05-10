using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrRectangle : Character //INHERITANCE
{
    public override void Greet() //POLYMORPHISM
    {
        Talk("Nice to meet you, " + GameManager.Instance.playerName + ". I'm " + Name + " and I'm really kind.");
    }

    public override void SayGoodbye()
    {
        Talk("Bye, see you next time!");
    }

    protected override void DemandFood()
    {
        Talk("Let's have dinner!");
    }

    protected override void DemandNothing()
    {
        Talk("No, thanks. I'm happy right now");
    }

    protected override void DemandSleep()
    {
        Talk("I talking with you, but it's getting late...");
    }

    protected override void DemandSpecial()
    {
        Talk("Oh,I have an idea. Let's do something together");
    }
}
