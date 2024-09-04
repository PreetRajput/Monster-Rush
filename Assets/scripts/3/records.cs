using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

using UnityEngine;
using UnityEngine.UI;


public class records : MonoBehaviour
{
    // Start is called before the first frame updat
    private Text record;
    
    void Awake(){
         record= GetComponent<Text>();
    }


     void Start(){
            if ((float)GameOver.duration>PlayerPrefs.GetFloat("record"))
               {
                    Debug.Log("preet is great");
                    PlayerPrefs.SetFloat("record", (float)GameOver.duration);
               }
               
                    Debug.Log(PlayerPrefs.GetFloat("record"));
                    Debug.Log((float)GameOver.duration);
               record.text= $"{PlayerPrefs.GetFloat("record")}";
     }

  




    
}
