using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float horizontal;
    private float speed = 20f; // speed player

    public GameObject bulet; // use bullet prefab 

    void Start()
    {
        transform.position = new Vector2(0f, -3.4f); // set position
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); // controll player

        if (Input.GetKeyDown(KeyCode.W)) // shooting
        {
            Instantiate(bulet, transform.position, Quaternion.identity); // spawn bullet
        }

    }
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontal); // move left and right

        // Stop condition,Setting the boundaries of the movement
        if (transform.position.x < -8f)
            transform.position = new Vector2(-8f, -3.4f);

        if (transform.position.x > 8f)
            transform.position = new Vector2(8f, -3.4f);

    }
}
