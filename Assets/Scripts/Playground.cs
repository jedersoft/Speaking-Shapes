using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playground : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.character[0].transform.position = new Vector3(-5, 2, 0);
        GameManager.Instance.character[1].transform.position = new Vector3(0, 2, 0);
        GameManager.Instance.character[1].transform.position = new Vector3(5, 2, 0);
    }
}
