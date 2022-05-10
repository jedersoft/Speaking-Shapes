using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrCircle : Character //INHERITANCE
{
    public override void Greet() //POLYMORPHISM
    {
        Talk("...hey, I'm " + Name + ". Now please don't disturb me, okay?");
    }

    public override void SayGoodbye()
    {
        Talk("Finally...");
    }

    protected override void DemandFood()
    {
        Talk("Maybe give me some food or else I'm just wasting my time here");
    }

    protected override void DemandNothing()
    {
        Talk("No, I don't want anything from you!");
    }

    protected override void DemandSleep()
    {
        Talk("You are so lame, you even make me tired!");
    }

    protected override void DemandSpecial()
    {
        Talk("Please, just let me go! That's all I want!");
    }
}
