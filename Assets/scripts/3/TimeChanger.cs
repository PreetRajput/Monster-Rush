using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeChanger : MonoBehaviour
{
    private Text Time;
    void Start(){
        Time= GetComponent<Text>();
        Time.text= $"Time: {GameOver.duration}"; 

    }



}
