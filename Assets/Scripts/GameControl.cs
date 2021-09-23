using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject enemy;

    [SerializeField] float timer;
    float timeSpawn = 2f;
    Vector2 plaсeSpawn; //= new Vector2( 5f, 6f)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if( timer >= timeSpawn)
        {
           timer = 0f;

           plaсeSpawn = new Vector2(Random.Range(-5f,5f), 6f);

           Instantiate(enemy, plaсeSpawn, Quaternion.identity);
        }
    }
}
