using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private SpriteRenderer body;
    [SerializeField] private SpriteRenderer leftEye;
    [SerializeField] private SpriteRenderer rightEye;
    private Color mainColor;
    public Color MainColor
    {
        get
        {
            return mainColor;
        }
        set
        {
            if (GameManager.Instance.CurrentStepID != 1)
                return;
            mainColor = value;
            body.color = mainColor;
        }
    }
    private Color eyeColor;
    public Color EyeColor
    {
        get
        {
            return eyeColor;
        }
        set
        {
            if (GameManager.Instance.CurrentStepID != 1)
                return;
            eyeColor = value;
            leftEye.color = eyeColor;
            rightEye.color = eyeColor;
        }
    }
    private string characterName;
    public string Name
    {
        get
        {
            return characterName;
        }
        set
        {
            if (GameManager.Instance.CurrentStepID != 1)
                return;
            characterName = value;
            Greet(); //ABSTRACTION
        }
    }
    protected void Talk(string text)
    {
        DialogueBox.Instance.ShowText(text);
    }
    public abstract void Greet();
    public void RandomDemand()
    {
        int DemandID = Random.Range(0, 4);
        Demand((Demands)DemandID);
    }
    private enum Demands { Food, Sleep, Special, Nothing};
    private void Demand(Demands demand)
    {
        switch(demand)
        {
            case Demands.Food:
                DemandFood();
                break;
            case Demands.Sleep:
                DemandSleep();
                break;
            case Demands.Special:
                DemandSpecial();
                break;
            case Demands.Nothing:
                DemandNothing();
                break;
        }
    }
    protected abstract void DemandFood();
    protected abstract void DemandSleep();
    protected abstract void DemandSpecial();
    protected abstract void DemandNothing();
    public abstract void SayGoodbye();
}
