using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeToLast : MonoBehaviour
{

    private bool isCollidingInteract = false;
    void OnTriggerStay2D(Collider2D other)

    {
        if (other.CompareTag("Player"))
        {
            if (!isCollidingInteract)
            {
                SceneManager.LoadScene("PhoneScene");
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
