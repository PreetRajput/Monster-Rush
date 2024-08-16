using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_2 : MonoBehaviour
{
    // Start is called before the first frame update
private float walkforce= 10f;
private float jumpforce= 15f;

private bool trash;
private float movementX;
private Animator anim;
private SpriteRenderer sr;
private Rigidbody2D mybody;

private Collider2D cd;

        public void Awake(){
            anim= GetComponent<Animator>();
            sr= GetComponent<SpriteRenderer>();
            mybody= GetComponent<Rigidbody2D>();
            cd= GetComponent<Collider2D>();

        }
   public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        walk();
        jump();
        animateWhileWalking();
    }
    void walk(){
        movementX= Input.GetAxisRaw("Horizontal");
        transform.position+= new Vector3(movementX, 0f, 0f) * walkforce * Time.deltaTime;
    }
    void animateWhileWalking(){
        if (movementX>0)
        {
            anim.SetBool("walk", true);
            sr.flipX= false;
        }
        else if(movementX<0){
            anim.SetBool("walk", true);
            sr.flipX= true;

        }
        else{
            anim.SetBool("walk", false);

        }
    }
    void jump(){
        if (Input.GetButtonDown("Jump") && trash)
        {
            mybody.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
            trash= false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Ground"))
        {
            trash= true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject); 
             SceneManager.LoadScene("GameOver");

        }
    }
    
}
