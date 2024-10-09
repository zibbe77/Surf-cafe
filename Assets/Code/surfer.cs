using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surfer : MonoBehaviour
{
    // Start is called before the first frame update


    Rigidbody2D rigB;
    [SerializeField] float moveSpeed = 10;

    void Start()
    {
        rigB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        rigB.velocity = new Vector2(1 * moveSpeed * Time.deltaTime, rigB.velocity.y);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "PickupSpot")
        {

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SurferDie")
        {
            Destroy(gameObject);
        }
    }

}
