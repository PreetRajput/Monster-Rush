using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public static double start;
    private Text Timeholder;
    void Start()
    {
        Timeholder= GetComponent<Text>();
    }

  

    // Update is called once per frame
    void Update()
    {
        start= Math.Round(Time.timeSinceLevelLoad, 1);
        

       Timeholder.text= $"Time: {start}"; 
    }
}
