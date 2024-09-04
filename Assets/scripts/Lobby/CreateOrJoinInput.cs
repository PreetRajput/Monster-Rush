using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class CreateOrJoinInput : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public InputField CreateField;
    public InputField JoinField;

    public static int x=0;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(CreateField.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(JoinField.text);
        x=1;
    }
    public override void OnJoinedRoom()
    {
        
            
            PhotonNetwork.LoadLevel("gameplay");
        
       
    }

}
