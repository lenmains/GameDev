using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPeggle : MonoBehaviour
{
    public Color newColor = Color.green;

    public void OnCollisionEnter2D(Collision2D collision)
    {

        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;


    }

// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
