using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoScript : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag != "fuerte")
        {
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionX;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        rigidbody2D.constraints = RigidbodyConstraints2D.None;
    }
}

    

