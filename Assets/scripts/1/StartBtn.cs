using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class StartBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void startGame()
    {
        
        int name= int.Parse( EventSystem.current.currentSelectedGameObject.name);
        CharacterStorage.CharIndex= name;
            SceneManager.LoadScene("gameplay");
    }
}
