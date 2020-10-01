using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator _doorAnim;
    public string tagToCompare = "Pumpkin";

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Pumpkin"))
        {
            _doorAnim.SetBool("isOpening", true);
        }
        
    }

    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.CompareTag("Pumpkin"))
        {
            _doorAnim.SetBool("isOpening", false);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        _doorAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
}
