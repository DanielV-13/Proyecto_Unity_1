using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    public float bulletSpeed = 13f;
    public GameManager myGameManager;


    void Start()
    {
       myRigidbody2D = GetComponent<Rigidbody2D>();
       myGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody2D.linearVelocity = new Vector2(bulletSpeed, myRigidbody2D.linearVelocity.y);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ItemGood"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("ItemBad"))
        {
            myGameManager.AddScore();
            Destroy(collision.gameObject);
        }
    }
}