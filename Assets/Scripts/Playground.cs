using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playground : MonoBehaviour
{
    public GameObject[] buttons = new GameObject[3];
    [SerializeField] private GameObject endScreen;
    private void Start()
    {
        foreach(Character character in GameManager.Instance.character)
        {
            character.gameObject.SetActive(true);
        }
        GameManager.Instance.character[0].transform.position = new Vector3(-5, 2, 0);
        GameManager.Instance.character[1].transform.position = new Vector3(0, 2, 0);
        GameManager.Instance.character[2].transform.position = new Vector3(5, 2, 0);
    }
    public void MakeLeave(int ID)
    {
        Character character = GameManager.Instance.character[ID];
        character.SayGoodbye();
        character.gameObject.SetActive(false);
        buttons[ID].SetActive(false);
        foreach (var obj in GameManager.Instance.character)
        {
            if (obj.gameObject.activeSelf == true)
                return;
        }
        endScreen.SetActive(true);
    }
}
