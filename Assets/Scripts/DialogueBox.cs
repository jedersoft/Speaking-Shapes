using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueBox : Singleton<DialogueBox> //Inheritance
{
    [SerializeField] private GameObject box;
    [SerializeField] private TextMeshProUGUI text;
    public void ShowText(string textToSay)
    {
        ShowUp(); //ABSTRACTION
        text.text = textToSay;
    }
    private void ShowUp()
    {
        box.SetActive(true);
        text.gameObject.SetActive(true);
    }
    private void Disappear()
    {
        box.SetActive(false);
        text.gameObject.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            Disappear(); //ABSTRACTION
    }
}
