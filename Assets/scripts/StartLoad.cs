using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLoad : MonoBehaviour
{
    public static float started;

     public void OnEnable(){
        SceneManager.sceneLoaded += OnLoadingFinished;
    }
   public void OnDisable(){
        SceneManager.sceneLoaded -= OnLoadingFinished;


    }

    void OnLoadingFinished(Scene scene, LoadSceneMode mode){

       
        Instantiate(CharacterStorage.instance.characters[CharacterStorage.instance.CharIndex]);
        started= Time.time;

        Debug.Log(started);
            
        
    } 
    


   

}
