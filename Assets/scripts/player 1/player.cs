using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class player : MonoBehaviour
{
    [SerializeField]
    private float moveforce= 10f;

    PhotonView view;
    private float jumpforce= 15f;
    [SerializeField]
    private float movementX;
    private Rigidbody2D mybody;
    private Animator anim;
    private bool trash;

    private string ENEMY_TAG= "Enemy";
    
    private string walk_Animation= "walk";
    private SpriteRenderer sr;
    private BoxCollider2D bc;

    public void Awake()
    {
        mybody= GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
        sr= GetComponent<SpriteRenderer>();
        bc= GetComponent<BoxCollider2D>();
        view= GetComponent<PhotonView>();
    }

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
        if (CharacterStorage.CharIndex==-1)
        {
            
            if (view.IsMine)
                {    
                    walk();
                   animate();
                    jump();
                }
        }
        else{
                    walk();
                    animate();
                    jump();

        }
            
    }

    
    void walk(){
        
        movementX= Input.GetAxisRaw("Horizontal");
        transform.position+= new Vector3(movementX, 0f, 0f) * moveforce * Time.deltaTime; 

    }
    void animate(){

            if (movementX>0)
            {
                anim.SetBool(walk_Animation, true);
                sr.flipX= false;
            }
            else if(movementX<0)
            {
                anim.SetBool(walk_Animation, true);
                sr.flipX= true;

            }
            else
            {
                anim.SetBool(walk_Animation, false);
            }

    }

    void jump(){
       
        
        if(Input.GetButtonDown("Jump") && trash){
            trash= false;
            mybody.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
            
        }
            
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            trash= true;
        }

        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
          
             SceneManager.LoadScene("GameOver");
        }
        

    }





} //class 

