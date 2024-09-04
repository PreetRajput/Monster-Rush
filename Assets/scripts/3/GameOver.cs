using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    private float ended;
    public static double duration;
   void OnEnable(){
    SceneManager.sceneLoaded+= OnLoadingFinished;
   }
void OnDisable(){
    SceneManager.sceneLoaded-= OnLoadingFinished;
    
   }

    void OnLoadingFinished(Scene scene, LoadSceneMode mode){
        ended= Time.time;
        duration= Math.Round(ended-StartLoad.started, 1);
    }




}
