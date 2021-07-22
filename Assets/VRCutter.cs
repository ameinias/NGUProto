using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class VRCutter : MonoBehaviour
{

    public TMP_Text text; 
    public void CutRope()
    {

        text.text = "cut!!";

    }
}
