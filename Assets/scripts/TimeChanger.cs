using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeChanger : MonoBehaviour
{
    private Text Time;
    void Start(){
        Time= GetComponent<Text>();
        Debug.Log(Time.text);
        Time.text= $"Time: {GameOver.duration}"; 
        Debug.Log(Time.text);

    }



}
