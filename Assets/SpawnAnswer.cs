using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnswer : MonoBehaviour
{
    private bool on;
    Vector3 position1;
    Vector3 position2;
    [SerializeField] AudioClip toPlay;
    [SerializeField] AudioSource Source;
    [SerializeField] GameObject option1;
    [SerializeField] GameObject option2;
    [SerializeField] float[] spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        position1 = new Vector3(spawnPoint[0], spawnPoint[1], 0);
        position2 = new Vector3(spawnPoint[2], spawnPoint[3], 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            if (Input.GetMouseButton(0))
            {
                Source.Stop();
                Source.PlayOneShot(toPlay);
                option1.transform.position = position1;
                option2.transform.position = position2;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        on = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        on = false;
    }
}
