using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class TriggerEnd : MonoBehaviour
{


    void Start()
    {
      //  Debug.Log("Um, actually...");

    }

    private void OnTriggerEnter(Collider other)
    {
    

        if (other.gameObject.tag == "EndObject")

        {
            SlimeCounter.GameOver();


            StartCoroutine(FindObjectOfType<FadeToPink>().FadeAndLoadScene(FadeToPink.FadeDirection.In, "ACT2"));
        }


    }
}
