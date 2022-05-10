using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameField;
    public void StartGame()
    {
        GameManager.Instance.StartGame(nameField.text);
    }
    public void ExitGame()
    {
        GameManager.Instance.QuitGame();
    }
}
