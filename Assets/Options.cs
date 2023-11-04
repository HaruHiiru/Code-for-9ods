using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    [SerializeField] Vector2[] pos;
    [SerializeField] GameObject o1;
    [SerializeField] GameObject o2;
    bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggered)
        {
            triggered = true;
            o1.transform.position = pos[0];
            o2.transform.position = pos[1];
        }


    }
}
