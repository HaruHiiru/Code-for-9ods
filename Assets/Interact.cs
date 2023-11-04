using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private bool isCollidingInteract = false;
    void OnTriggerStay2D(Collider2D other)

    {
        if (other.CompareTag("Player"))
        {
            if (!isCollidingInteract)
            {
                print("It's working!");
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
