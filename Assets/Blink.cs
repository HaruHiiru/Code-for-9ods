using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    int j;
    float i;
    bool up;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.005f;
        i = 1;
        j = 2;
    }

    // Update is called once per frame
    void Update()
    {

        if(i < 0)
        {
            j--;
            up = true;
        }

        if(i > 1)
        {
            up = false;
        }

        if (up)
        {
            i += speed; 
        }
        else
        {

            i -= speed;
        }
        if (j > 0)
            GetComponent<SpriteRenderer>().material.color = new Color(0, 0, 0, i);
    }
}
