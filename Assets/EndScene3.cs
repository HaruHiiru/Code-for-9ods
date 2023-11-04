using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene3 : MonoBehaviour
{
    bool hover;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hover && Input.GetMouseButtonDown(0))
        {
            source.PlayOneShot(clip);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hover = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hover = false;
    }
}
