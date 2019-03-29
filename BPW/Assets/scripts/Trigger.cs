using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public EndTrigger endTrigger;
    public BoxCollider boxCollider;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("we are hit");
            transform.parent.GetComponent<EndTrigger>().boxCount += 1;
            boxCollider.enabled = false;
        }
    }
}
