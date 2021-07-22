using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchHead : MonoBehaviour
{
    public GameObject parent;



    public void Update()
    {
        transform.position = parent.transform.position;
    }
}
