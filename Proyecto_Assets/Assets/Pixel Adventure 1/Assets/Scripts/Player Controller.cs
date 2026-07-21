using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour
{
    public float playerJumpForce = 20f;
    public float playerSpeed= 5f;
    public Sprite[] mySprites;
    private int index=0;

    private Rigidbody2D myRigidbody2D;
    private SpriteRenderer mySpriteRenderer;
    //public GameObject Bullet;
   // public GameManager myGameManager;
    
    
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(WalkCoRutine());
       // myGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Configurar el salto cuando se presiona la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.linearVelocity = new Vector2(myRigidbody2D.linearVelocity.x, playerJumpForce);
        }
        
        //Configurar el movimiento horizontal del jugador (siempre avanza para adelante)
        myRigidbody2D.linearVelocity = new Vector2(playerSpeed, myRigidbody2D.linearVelocity.y);

        //Configurar el disparo cuando se presiona la tecla E
        //if(Input.GetKeyDown(KeyCode.E))
        //{
        //    Instantiate(Bullet, transform.position, Quaternion.identity);
        //}

    }

    IEnumerator WalkCoRutine()
    {
       yield return new WaitForSeconds(0.05f);
       mySpriteRenderer.sprite = mySprites[index];
       index++;
       if(index >= mySprites.Length)
       {
           index = 0;
       }
       StartCoroutine(WalkCoRutine());

    }




}
