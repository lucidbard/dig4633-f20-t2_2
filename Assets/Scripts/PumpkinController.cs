using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations; 

public class PumpkinController : MonoBehaviour
{
    public Animator _pumpkinAnim;

    void OnTriggerEnter(Collider obj)
    {
        Debug.Log(obj.gameObject.name);
        _pumpkinAnim.SetBool("isTurning", true);        
    }

    void OnTriggerExit(Collider obj)
    {
        Debug.Log(obj.gameObject.name);
        _pumpkinAnim.SetBool("isTurning", false);
                    
    }

    // Start is called before the first frame update
    void Start()
    {
        _pumpkinAnim = this.transform.parent.GetComponent<Animator>();
    }
}
