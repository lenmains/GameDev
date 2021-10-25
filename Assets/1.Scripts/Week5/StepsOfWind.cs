using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsOfWind : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public List<Sprite> spriteList = new List<Sprite>();
    public float delay = 1.0f;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        
        StartCoroutine(Animate());
    }

    IEnumerator Animate()
    {
        int counter = 0;


        StartCoroutine(Move());
        while (true)
        {

            spriteRenderer.sprite = spriteList[0];
            yield return new WaitForSeconds(delay);
            counter++;

            if (counter > spriteList.Count - 1)
            {
                counter = 0;
            }
        }
    }

    IEnumerator Move()
    {

        while(true)
        {
            transform.position = new Vector3(transform.position.x - Time.deltaTime, transform.position.y,
                transform.position.z);
            yield return null;

            if (transform.position.x < -10) ;
        }
    }
}
