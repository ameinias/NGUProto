using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DebugSystem : MonoBehaviour
{

    private static DebugSystem _instance;

    public static DebugSystem Instance { get { return _instance; } }

    public TMP_Text DebugText;



    public static void UpdateDebug(string value)
    {

        _instance.DebugText.text = value;
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

    void Start()
    {

      
    }

    void Update()
    {
       
    }



}
