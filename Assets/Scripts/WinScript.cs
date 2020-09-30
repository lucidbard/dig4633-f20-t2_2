using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject uiObject;
    public string tagToCompare = "Pumpkin";
    void Start ()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Pumpkin"))
        {
            uiObject.SetActive(true);
            Debug.Log("Win");
        }
    }
}
