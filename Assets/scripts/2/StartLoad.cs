using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class StartLoad : MonoBehaviour
{
    public static float started;
    public GameObject player;
     public void OnEnable(){
        SceneManager.sceneLoaded += OnLoadingFinished;
    }
   public void OnDisable(){
        SceneManager.sceneLoaded -= OnLoadingFinished;


    }

    void OnLoadingFinished(Scene scene, LoadSceneMode mode){
        Debug.Log(CharacterStorage.CharIndex);

       if (CharacterStorage.CharIndex==-1)
       {
            if (CreateOrJoinInput.x==0)
            {
                
                UnityEngine.Vector2 randomPosition= new Vector2(Random.Range(0, 10), Random.Range(0,0));
                PhotonNetwork.Instantiate(player.name,randomPosition,quaternion.identity);
                Debug.Log("SDaasdsadadadd");
            }
       }
       else
       {
            Instantiate(CharacterStorage.instance.characters[CharacterStorage.CharIndex]);
            Debug.Log("else part");
       }
        
        started= Time.time;

            
        
    } 
    


   

}
