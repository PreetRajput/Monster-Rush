using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform Player;

    [SerializeField]
    private Vector3 tempPos;
    public void Start()
    {
        Player= GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    public void LateUpdate()
    {
        if (!Player)
        {
           return; 
        }
        if (Player.transform.position.x<=-60)
        {
            tempPos.x= -60;
            transform.position= tempPos;
        }
        else if(Player.transform.position.x>=60){
            tempPos.x= 60;
            transform.position= tempPos;
        }
        else{
        tempPos= transform.position;
        tempPos.x= Player.position.x;
        transform.position= tempPos;
        }
    }
}
