using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject toFollow;
    Vector3 positon;
    // Start is called before the first frame update
    void Start()
    {
        positon = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(toFollow.transform.position.x, positon.y, positon.z);
    }
}
