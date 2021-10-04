using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipWing : MonoBehaviour
{
    [SerializeField] private bool flag = false;

    public Sprite sprite1;
    public Sprite sprite2;

    void Change()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!flag)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
                flag = true;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
                flag = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Change();
    }
}
