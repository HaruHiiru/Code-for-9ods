using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;
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
            print("trigger");
            source.PlayOneShot(clip);
            triggered = true;
        }
        
        
    }
}
