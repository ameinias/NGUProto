using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class TriggerEnd : MonoBehaviour
{


    void Start()
    {
        Debug.Log("Um, actually...");

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");

        if (other.gameObject.tag == "EndObject")

        {
            DebugSystem.GameOver();
            Debug.Log("RealTrigger");
        }


    }
}
