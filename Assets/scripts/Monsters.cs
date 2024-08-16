using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;

public class Monsters : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D mybody;
    void Start()
    {
        
    }

    public void Awake(){
        speed= 10;
        mybody= GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move(){
        
        mybody.velocity= new UnityEngine.Vector2(speed, mybody.velocity.y);

    }
}
