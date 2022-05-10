using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour
{
    [SerializeField] private Character[] character = GameManager.Instance.character;
    private int currentCharacterID = 0;
    [SerializeField] private TMP_InputField input;
    [SerializeField] private Image[] bodyColors = new Image[4];
    [SerializeField] private Image[] eyeColors = new Image[4];
    private void Start()
    {
        character[0].gameObject.SetActive(true);
    }
    public void ChangeName()
    {        
        character[currentCharacterID].Name = input.text;
    }
    public void ChangeMainColor(int ID)
    {
        character[currentCharacterID].MainColor = bodyColors[ID].color;
    }
    public void ChangeEyeColor(int ID)
    {
        character[currentCharacterID].EyeColor = eyeColors[ID].color;
    }
    public void Continue()
    {
        if (character[currentCharacterID].Name == "")
            return;
        if(currentCharacterID == 2)
        {
            GameManager.Instance.NextStep();
            return;
        }
        NextCharacter();
    }
    private void NextCharacter()
    {
        character[currentCharacterID].gameObject.SetActive(false);
        currentCharacterID++;
        character[currentCharacterID].gameObject.SetActive(true);
        input.text = "";
    }
}
