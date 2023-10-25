using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int destroyedBullet;
    public GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject createdBullet = Instantiate(bullet, transform.position, transform.rotation);
            createdBullet.GetComponent<Bullet>().myPlayer = this;

        }
        
    }
}

