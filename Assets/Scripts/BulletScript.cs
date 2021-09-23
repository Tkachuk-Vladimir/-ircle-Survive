using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float speed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);// momevement bullet down

        if (transform.position.y > 5.7f || transform.position.y < -5.7f) // condition destroy object
            Destroy(gameObject);
    }
}
