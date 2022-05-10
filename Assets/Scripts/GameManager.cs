using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> //Inheritance
{
    public string playerName;
    [SerializeField] private GameObject[] gameSteps = new GameObject[3];
    private int currentStepID = 0;
    //Abstraction
    private void NextStep()
    {
        if(currentStepID > 2 || currentStepID < 0)
        {
            Debug.LogError("Invalid step ID");
            return;
        }
        gameSteps[currentStepID].SetActive(false);
        currentStepID++;
        gameSteps[currentStepID].SetActive(true);
    }
    public void StartGame(string newName)
    {
        if (newName == "")
            return;
        playerName = newName;
        NextStep();        
    }
    private void SetCharacterName(string newName)
    {

    }
}
