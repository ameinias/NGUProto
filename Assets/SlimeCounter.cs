using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SlimeCounter : MonoBehaviour
{
    public TMP_Text DebugText;

    [Header("Counters")]
    public int slimeStartCounter;
    public int slimeRiseCounter;

    public float slimeStartCounterCurrent;
    public float slimeRiseCounterCurrent;
    Vector3 startPosition;

    public float t;
    [Header("Objects")]
    public GameObject slimePlane;
    public Transform target;
    public GameObject slimeBox;
    public Transform slimeBoxtarget;
    public bool startSlime = false;


         

    private void Start()
    {
      

     slimeStartCounterCurrent = slimeStartCounter;
    slimeRiseCounterCurrent = slimeRiseCounter;

        startPosition = slimePlane.transform.position;
}

    // Update is called once per frame
    void Update()
    {
    Timer();





    DebugText.text = " Start:  " + slimeStartCounterCurrent + " Rise:  " + slimeRiseCounter;
        if (startSlime)
        {
            t += Time.deltaTime / slimeRiseCounterCurrent;
            slimePlane.transform.position = Vector3.Lerp(startPosition, target.position, t);

            slimeBox.transform.position = Vector3.Lerp(startPosition, slimeBoxtarget.position, t);

        }

    }

    public void Timer()
    {
       if( slimeStartCounterCurrent < 0)
        {

            Debug.Log("Raise water line");
            startSlime = true;



        } else {
            slimeStartCounterCurrent -= Time.deltaTime;
        }


    }


}
