using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugSystem : MonoBehaviour
{

    private static DebugSystem _instance;

    public static DebugSystem Instance { get { return _instance; } }


    [Header("Game Over")]

    public GameObject GameOverPanel; 


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

        GameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }





    public static void GameOver()
    {
        _instance.GameOverPanel.SetActive(true);
    }


}
