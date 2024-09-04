using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterStorage : MonoBehaviour
{

    public GameObject[] characters;
    public static CharacterStorage instance;

    public static int CharIndex= -1;

   

    void Awake(){
        if (instance==null)
        {
            instance= this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
