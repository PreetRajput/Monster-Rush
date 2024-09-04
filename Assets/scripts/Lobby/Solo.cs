using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Solo : MonoBehaviour
{
    // Start is called before the first frame update
   public void SoloGame(){
    SceneManager.LoadScene("Start");
   }
}
