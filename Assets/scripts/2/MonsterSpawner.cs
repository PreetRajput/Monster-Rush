using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Unity.Mathematics;
using Random = UnityEngine.Random;
public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] allEnemies;
    private GameObject spawnedMonster;

    [SerializeField]
    private Transform leftpos;

    [SerializeField]
    private Transform rightpos;
    private int monsIndex;

    private SpriteRenderer sr;
    private int side;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawner());

    }
    void Awake(){
        spawnedMonster= GetComponent<GameObject>();

    }

    // Update is called once per frame
    public void Update()
    {
    }

    

    IEnumerator spawner()
    {
        while (true)
        {
        yield return new WaitForSeconds(Random.Range(1,5));
        monsIndex= Random.Range(0, allEnemies.Length);

        side= Random.Range(0,2);
        //0 ==> left
        if (side==0)
        {
          spawnedMonster= PhotonNetwork.Instantiate(allEnemies[monsIndex].name, leftpos.transform.position, Quaternion.identity);
          spawnedMonster.GetComponent<Monsters>().speed= Random.Range(1,10);
          sr= spawnedMonster.GetComponent<SpriteRenderer>();
          sr.flipX= false;
        }
        else //1 ==> right 
        {
          spawnedMonster= PhotonNetwork.Instantiate(allEnemies[monsIndex].name, rightpos.transform.position, Quaternion.identity);
          spawnedMonster.GetComponent<Monsters>().speed= -Random.Range(1,10);
          sr= spawnedMonster.GetComponent<SpriteRenderer>();
          sr.flipX= true;
        }
            
        } // while 


    }
}
