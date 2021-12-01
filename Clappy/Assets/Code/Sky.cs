using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour
{
    public float speed;
    float skylenght;
    
 

    // Start is called before the first frame update
    void Start()
    {
        
        skylenght = 29.01535f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime,
            transform.position.y);
        if (gameObject.CompareTag("Sky"))
        {
            if (transform.position.x <= -skylenght)
            {
                transform.position = new Vector2(transform.position.x + 2 * skylenght,
                    transform.position.y);
            }
        }
        if(gameObject.CompareTag("Column"))
        {
            if(transform.position.x<=-18)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
