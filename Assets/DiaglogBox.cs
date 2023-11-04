using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaglogBox : MonoBehaviour
{
    bool hover = false;
    [SerializeField] GameObject[] options;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hover && Input.GetMouseButtonDown(0))
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
            hover = false;
            options[0].transform.position = new Vector3(-3.89f, 0.4f, 0) ;
            options[1].transform.position = new Vector3(4.2f, 0.31f, 0);
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
