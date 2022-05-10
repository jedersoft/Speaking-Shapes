using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> //INHERITANCE 
{
    public Character[] character = new Character[3];
    public string playerName;
    [SerializeField] private GameObject[] gameSteps = new GameObject[3];
    public int CurrentStepID { get; private set; } //ENCAPSULATION
    //ABSTRACTION
    public void NextStep()
    {
        if(CurrentStepID > 2 || CurrentStepID < 0)
        {
            Debug.LogError("Invalid step ID");
            return;
        }
        gameSteps[CurrentStepID].SetActive(false);
        CurrentStepID++;
        gameSteps[CurrentStepID].SetActive(true);
    }
    public void StartGame(string newName)
    {
        if (newName == "")
            return;
        playerName = newName;
        NextStep(); //ABSTRACTION
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
