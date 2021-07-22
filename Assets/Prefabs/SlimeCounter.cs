using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SlimeCounter : MonoBehaviour
{

    private static SlimeCounter _instance;
    public static SlimeCounter Instance { get { return _instance; } }


 

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

    [Header("Game Over")]

    public GameObject GameOverPanel;
    public static void GameOver()
    {
      _instance.GameOverPanel.SetActive(true);
    }

    private void Start()
    {
        GameOverPanel.SetActive(false);

        slimeStartCounterCurrent = slimeStartCounter;
    slimeRiseCounterCurrent = slimeRiseCounter;

        startPosition = slimePlane.transform.position;
}

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    void Update()
    {
    Timer();


        DebugSystem.UpdateDebug(" Start:  " + slimeStartCounterCurrent + " Rise:  " + slimeRiseCounter);





        if (startSlime)
        {
            t += Time.deltaTime / slimeRiseCounterCurrent;
            slimePlane.transform.position = Vector3.Lerp(startPosition, target.position, t);

            slimeBox.transform.position = Vector3.Lerp(startPosition, slimeBoxtarget.position, t);

            if (slimeBox.transform.position == slimeBoxtarget.position)
            {
              GameOver();
                StartCoroutine(FindObjectOfType<FadeToPink>().FadeAndLoadScene(FadeToPink.FadeDirection.In, "ACT2"));




            }

        }

    }

    public void Timer()
    {
       if( slimeStartCounterCurrent < 0)
        {


            startSlime = true;



        } else {
            slimeStartCounterCurrent -= Time.deltaTime;
        }


    }


}
