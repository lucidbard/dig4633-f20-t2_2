using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapManager : MonoBehaviour
{
    public GameObject Scarecrow;
    public bool SawSnapped = false;
    public bool HammerSnapped = false;

void Start()
{
    Scarecrow.SetActive(true);
}

public void HammerUnSnappedAction()
    {
        HammerSnapped = false; 
        Debug.Log("Snapped");
    }

    public void HammerSnappedAction()
    {
        HammerSnapped = true;
        Scarecrow.SetActive(false);
        Debug.Log("Snapped");
    }
    public void UnSnapped()
    {
        SawSnapped = false; 
        Debug.Log("Snapped");
    }

    public void Snapped()
    {
        SawSnapped = true;
        Scarecrow.SetActive(false);
        Debug.Log("Snapped");
    }
}
