using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchLimb : MonoBehaviour
{
    public GameObject parent;
    public GameObject targetHand;
    public GameObject accuracyGizmo;
    public float accuracy;



    public void Update()
    {
        transform.position = parent.transform.position;
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == targetHand)
            accuracyGizmo.GetComponent<Renderer>().material.SetColor("_Color", Color.white);

    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject == targetHand)
        {
       

            accuracyGizmo.GetComponent<Renderer>().material.SetColor("_Color", Color.green);


            accuracy += Time.deltaTime;
        }
    }
}
