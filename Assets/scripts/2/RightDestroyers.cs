using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDestroyers : MonoBehaviour
{

    
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
             

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("enemy collided");

            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
      
      

        }

    }
}
