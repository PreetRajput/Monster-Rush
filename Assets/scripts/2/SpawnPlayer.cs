using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.Numerics;
using Vector2 = UnityEngine.Vector2;
using Quaternion = UnityEngine.Quaternion;
public class SpawnPlayer : MonoBehaviour
{
   public  GameObject Player;

   public float minX;
   public float maxX;
   public float minY;
   public float maxY;

   public void Start(){
      if (CreateOrJoinInput.x==1)
      {
    UnityEngine.Vector2 randomPosition= new Vector2(Random.Range(minX,maxX), Random.Range(minY, maxY));
    PhotonNetwork.Instantiate(Player.name, randomPosition, Quaternion.identity);
         
      }
   }



}
