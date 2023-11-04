using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    [SerializeField] AudioClip[] Bad;
    [SerializeField] AudioClip Good;
    [SerializeField] AudioSource Source;
    [SerializeField] GameObject other;
    [SerializeField] GameObject caller;
    private bool hover;
    int random;
    int replay;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        replay = -1;
        position = other.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        random = Random.Range(0, 4);

        if(random == replay)
        {
            random = Random.Range(0, 4);
        }

        if (random == replay)
        {
            random = Random.Range(0, 4);
        }

        if (hover)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (gameObject.name == "W2")
                {
                    Source.Stop();
                    Source.PlayOneShot(Bad[random], 1);
                }
                else
                {
                    caller.GetComponent<BoxCollider2D>().isTrigger = false;
                    gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    Source.PlayOneShot(Good, 0.5f);
                    other.transform.position = position;
                    if(gameObject.name == "W1")
                        gameObject.transform.position = new Vector3(4.29f, 1f, 0);
                    else if(gameObject.name == "W11")
                        gameObject.transform.position = new Vector3(3.73f, -0.1f, 0);
                    else
                        gameObject.transform.position = new Vector3(3.87f, 0.05f, 0);
                }
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        hover = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hover = false;
    }
}
