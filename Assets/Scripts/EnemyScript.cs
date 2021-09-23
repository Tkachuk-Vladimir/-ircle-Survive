using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * -speed);


        if (transform.position.y <= -6.5f)
        {
            Destroy(gameObject);
        }
    }

    /*void OnTriggerEnter2D(Collider2D collider2D)
    {
       
            Debug.Log("hit");
            Destroy(this.gameObject);
        
    }
     */
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.name);
    }
}
