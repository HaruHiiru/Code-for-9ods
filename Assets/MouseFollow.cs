using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    Vector3 Position;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        Cursor.visible = false;
        Position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = new Vector3(Position.x, Position.y, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0);
        print(collision.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0);
    }
}
