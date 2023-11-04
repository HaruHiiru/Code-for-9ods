using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAudio : MonoBehaviour
{
    public GameObject gameObject;

    private bool isCollidingInteract = false;
    void OnTriggerStay2D(Collider2D other)

    {
        if (other.CompareTag("Player"))
        {
            if (!isCollidingInteract)
            {
                gameObject.SetActive(true);
                isCollidingInteract = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isCollidingInteract = false;
        }
    }
}
