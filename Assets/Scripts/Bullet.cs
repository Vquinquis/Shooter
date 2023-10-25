using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Player myPlayer;
    private Rigidbody2D rgbd;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        rgbd = gameObject.GetComponent<Rigidbody2D>();
        rgbd.velocity = Vector3.up*speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        myPlayer.destroyedBullet++;
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}

