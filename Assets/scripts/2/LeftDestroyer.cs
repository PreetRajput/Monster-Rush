using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDestroyer : MonoBehaviour
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
            Debug.Log("player collided");
            collision.gameObject.transform.position= new Vector3(GameObject.FindWithTag("right destroyer").transform.position.x-5, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
            Debug.Log("ASdasdsadsad");

        }

    }
}
