using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChickenCoop : MonoBehaviour
{
    public Text ChickenNumberText;
    public Text victoryText;
    public int ChickenCount;

    void Start()
    {
        ChickenCount = 0;
        ChickenCountText ();
        victoryText.text = "";
    }
    	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Chicken")
		{
            ChickenCount = ChickenCount + 1;

			ChickenCountText();
		}
	}
        void OnTriggerExit(Collider other)
    {
        if (other.tag == "Chicken")
        {

            ChickenCount = ChickenCount - 1;

            ChickenCountText();
        }
    }
    void ChickenCountText ()
    {
        ChickenNumberText.text = "Chickens Caught: " + ChickenCount.ToString ();
        if (ChickenCount >= 5)
        {
            victoryText.text = "Good Job!";
        }
    }
}
